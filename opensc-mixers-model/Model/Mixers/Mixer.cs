﻿using OpenSC.Model.General;
using OpenSC.Model.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Mixers
{

    public abstract class Mixer : ModelBase
    {

        public Mixer()
        { }

        public override void RestoredOwnFields()
        {
            restoreInputs();
        }

        public override void Removed()
        {
            base.Removed();
            OnProgramInputChanged = null;
            OnProgramInputNameChanged = null;
            OnPreviewInputChanged = null;
            OnPreviewInputNameChanged = null;
            StateChanged = null;
            StateStringChanged = null;
            InputsChanged = null;
            inputs.ForEach(i => i.RemovedFromMixer(this));
            inputs.Clear();
        }

        #region ID validation

        protected override void validateIdForDatabase(int id)
        {
            if (!MixerDatabase.Instance.CanIdBeUsedForItem(id, this))
                throw new ArgumentException();
        }
        #endregion

        #region Property: OnProgramInput, OnProgramInputName
        public event PropertyChangedTwoValuesDelegate<Mixer, MixerInput> OnProgramInputChanged;
        public event PropertyChangedOneValueDelegate<Mixer, string> OnProgramInputNameChanged;

        private MixerInput onProgramInput;

        public MixerInput OnProgramInput
        {
            get => onProgramInput;
            protected set
            {
                BeforeChangePropertyDelegate<MixerInput> beforeChangeDelegate = (ov, nv) => {
                    if (ov != null)
                        ov.NameChanged -= onProgramInputNameChangedHandler;
                };
                AfterChangePropertyDelegate<MixerInput> afterChangeDelegate = (ov, nv) => {
                    if (nv != null)
                        nv.NameChanged += onProgramInputNameChangedHandler;
                };
                if (!setProperty(this, ref onProgramInput, value, OnProgramInputChanged, beforeChangeDelegate, afterChangeDelegate))
                    return;
                OnProgramInputNameChanged?.Invoke(this, onProgramInput?.Name);
                RaisePropertyChanged(nameof(OnProgramInputName));
            }
        }

        public string OnProgramInputName => onProgramInput?.Name;

        private void onProgramInputNameChangedHandler(MixerInput input, string oldName, string newName)
            => OnProgramInputNameChanged?.Invoke(this, newName);
        #endregion

        #region Property: OnPreviewInput, OnPreviewInputName
        public event PropertyChangedTwoValuesDelegate<Mixer, MixerInput> OnPreviewInputChanged;
        public event PropertyChangedOneValueDelegate<Mixer, string> OnPreviewInputNameChanged;

        private MixerInput onPreviewInput;

        public MixerInput OnPreviewInput
        {
            get => onPreviewInput;
            protected set
            {
                BeforeChangePropertyDelegate<MixerInput> beforeChangeDelegate = (ov, nv) => {
                    if (ov != null)
                        ov.NameChanged -= onPreviewInputNameChangedHandler;
                };
                AfterChangePropertyDelegate<MixerInput> afterChangeDelegate = (ov, nv) => {
                    if (nv != null)
                        nv.NameChanged += onPreviewInputNameChangedHandler;
                };
                if (!setProperty(this, ref onPreviewInput, value, OnPreviewInputChanged, beforeChangeDelegate, afterChangeDelegate))
                    return;
                OnPreviewInputNameChanged?.Invoke(this, onPreviewInput?.Name);
                RaisePropertyChanged(nameof(OnPreviewInput));
            }
        }

        public string OnPreviewInputName => onPreviewInput?.Name;

        private void onPreviewInputNameChangedHandler(MixerInput input, string oldName, string newName)
            => OnPreviewInputNameChanged?.Invoke(this, newName);
        #endregion

        #region Property: State
        public event PropertyChangedTwoValuesDelegate<Mixer, MixerState> StateChanged;
        
        private MixerState state = MixerState.Unknown;

        public MixerState State
        {
            get => state;
            protected set => setProperty(this, ref state, value, StateChanged);
        }
        #endregion

        #region Property: StateString
        public event PropertyChangedTwoValuesDelegate<Mixer, string> StateStringChanged;

        private string stateString = "?";

        public string StateString
        {
            get => stateString;
            protected set => setProperty(this, ref stateString, value, StateStringChanged);
        }
        #endregion

        #region Inputs
        private ObservableList<MixerInput> inputs = new ObservableList<MixerInput>();

        public ObservableList<MixerInput> Inputs => inputs;

        [PersistAs("inputs")]
        [PersistAs(null, 1)]
        private MixerInput[] _inputs
        {
            get { return inputs.ToArray(); }
            set
            {
                inputs.Clear();
                if (value != null)
                    inputs.AddRange(value);
            }
        }

        public void AddInput()
        {
            int index = ((inputs.Count > 0) ? (inputs.Max(input => input.Index) + 1) : 1);
            inputs.Add(new MixerInput(string.Format("Input #{0}", index), this, index));
        }

        public void RemoveInput(MixerInput input)
        {
            inputs.Remove(input);
            input.RemovedFromMixer(this);
            if (input == onProgramInput)
                OnProgramInput = null;
            if (input == onPreviewInput)
                OnPreviewInput = null;
        }

        private void inputsChangedHandler()
        {
            InputsChanged?.Invoke(this);
            RaisePropertyChanged(nameof(Inputs));
        }
        private void restoreInputs()
        {
            foreach (MixerInput input in inputs)
                input.Mixer = this;
            foreach (MixerInput input in inputs)
                input.Restored();
        }

        public event PropertyChangedNoValueDelegate<Mixer> InputsChanged;
        #endregion

    }

}