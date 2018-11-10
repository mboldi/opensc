﻿using OpenSC.Model.Persistence;
using System;

namespace OpenSC.Model.Streams
{

    public abstract class Stream: ModelBase
    {

        public override void Restored()
        { }

        public delegate void IdChangedDelegate(Stream stream, int oldValue, int newValue);
        public event IdChangedDelegate IdChanged;

        public int id = 0;

        public override int ID
        {
            get { return id; }
            set
            {
                ValidateId(value);
                int oldValue = id;
                id = value;
                IdChanged?.Invoke(this, oldValue, value);
                RaisePropertyChanged(nameof(ID));
            }
        }

        public void ValidateId(int id)
        {
            if (id <= 0)
                throw new ArgumentException();
            if (!StreamDatabase.Instance.CanIdBeUsedForItem(id, this))
                throw new ArgumentException();
        }

        public delegate void NameChangedDelegate(Stream stream, string oldName, string newName);
        public event NameChangedDelegate NameChanged;

        [PersistAs("name")]
        private string name = "Test";

        public string Name
        {
            get { return name; }
            set
            {
                ValidateName(value);
                string oldName = name;
                name = value;
                NameChanged?.Invoke(this, oldName, value);
                RaisePropertyChanged(nameof(Name));
            }
        }

        public void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException();
        }

        public delegate void StateChangedDelegate(Stream stream, StreamState oldState, StreamState newState);
        public event StateChangedDelegate StateChanged;

        private StreamState state;

        public StreamState State
        {
            get { return state; }
            protected set {
                StreamState oldState = state;
                state = value;
                StateChanged?.Invoke(this, oldState, value);
                RaisePropertyChanged(nameof(State));
            }
        }

        public delegate void ViewerCountChangedDelegate(Stream stream, int? oldCount, int? newCount);
        public event ViewerCountChangedDelegate ViewerCountChanged;

        private int? viewerCount;

        public int? ViewerCount
        {
            get { return viewerCount; }
            protected set
            {
                int? oldCount = viewerCount;
                viewerCount = value;
                ViewerCountChanged?.Invoke(this, oldCount, value);
                RaisePropertyChanged(nameof(ViewerCount));
            }
        }

        protected override void afterUpdate()
        {
            base.afterUpdate();
            StreamDatabase.Instance.ItemUpdated(this);
        }

    }
}
