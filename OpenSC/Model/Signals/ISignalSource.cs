﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Signals
{

    public delegate void RegisteredSourceSignalNameChangedDelegate(ISignalSource signal, string newName);
    public delegate void RegisteredSourceSignalChangedDelegate(ISignalSource signal, ISignalSourceRegistered registeredSignal);

    public interface ISignalSource
    {

        #region Property: RegisteredSourceSignalName
        string RegisteredSourceSignalName { get; }
        string GetRegisteredSourceSignalName(List<object> recursionChain = null);
        event RegisteredSourceSignalNameChangedDelegate RegisteredSourceSignalNameChanged;
        #endregion

        #region Propety: RegisteredSourceSignal
        ISignalSourceRegistered RegisteredSourceSignal { get; }
        ISignalSourceRegistered GetRegisteredSourceSignal(List<object> recursionChain = null);
        event RegisteredSourceSignalChangedDelegate RegisteredSourceSignalChanged;
        #endregion

        #region Tallies
        IBidirectionalSignalTally RedTally { get; }
        IBidirectionalSignalTally YellowTally { get; }
        IBidirectionalSignalTally GreenTally { get; }
        #endregion

    }

}
