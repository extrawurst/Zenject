using System;
using ModestTree.Util;

namespace Zenject.Commands
{
    public interface ISignal
    {
    }

    // Zero Parameters
    public abstract class Signal : ISignal
    {
        public event Action Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal _signal = null;

            public Signal Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire()
            {
                _signal.Event();
            }
        }
    }

    // One Parameter
    public abstract class Signal<TParam1> : ISignal
    {
        public event Action<TParam1> Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal<TParam1> _signal = null;

            public Signal<TParam1> Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire(TParam1 arg1)
            {
                _signal.Event(arg1);
            }
        }
    }

    // Two Parameters
    public abstract class Signal<TParam1, TParam2> : ISignal
    {
        public event Action<TParam1, TParam2> Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal<TParam1, TParam2> _signal = null;

            public Signal<TParam1, TParam2> Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire(TParam1 arg1, TParam2 arg2)
            {
                _signal.Event(arg1, arg2);
            }
        }
    }

    // Three Parameters
    public abstract class Signal<TParam1, TParam2, TParam3> : ISignal
    {
        public event Action<TParam1, TParam2, TParam3> Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal<TParam1, TParam2, TParam3> _signal = null;

            public Signal<TParam1, TParam2, TParam3> Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire(TParam1 arg1, TParam2 arg2, TParam3 arg3)
            {
                _signal.Event(arg1, arg2, arg3);
            }
        }
    }

    // Four Parameters
    public abstract class Signal<TParam1, TParam2, TParam3, TParam4> : ISignal
    {
        public event Action<TParam1, TParam2, TParam3, TParam4> Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal<TParam1, TParam2, TParam3, TParam4> _signal = null;

            public Signal<TParam1, TParam2, TParam3, TParam4> Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire(TParam1 arg1, TParam2 arg2, TParam3 arg3, TParam4 arg4)
            {
                _signal.Event(arg1, arg2, arg3, arg4);
            }
        }
    }

    // Five Parameters
    public abstract class Signal<TParam1, TParam2, TParam3, TParam4, TParam5> : ISignal
    {
        public event ModestTree.Util.Action<TParam1, TParam2, TParam3, TParam4, TParam5> Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal<TParam1, TParam2, TParam3, TParam4, TParam5> _signal = null;

            public Signal<TParam1, TParam2, TParam3, TParam4, TParam5> Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire(TParam1 arg1, TParam2 arg2, TParam3 arg3, TParam4 arg4, TParam5 arg5)
            {
                _signal.Event(arg1, arg2, arg3, arg4, arg5);
            }
        }
    }

    // Six Parameters
    public abstract class Signal<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> : ISignal
    {
        public event ModestTree.Util.Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> Event = delegate {};

        public abstract class TriggerBase
        {
            [Inject]
            Signal<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> _signal = null;

            public Signal<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> Signal
            {
                get
                {
                    return _signal;
                }
            }

            public void Fire(TParam1 arg1, TParam2 arg2, TParam3 arg3, TParam4 arg4, TParam5 arg5, TParam6 arg6)
            {
                _signal.Event(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }
    }
}
