﻿using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SVOIA_IGRA.ViewModel
{
    public abstract partial class ViewModelBase : BaseInpc, IDisposable
    {
        private readonly Dictionary<string, object?> _properties = new();

        protected T? Get<T>([CallerMemberName] string propertyName = "")
        {
            T? value;
            if (_properties.TryGetValue(propertyName, out object? _prop))
            {
                value = (T?)_prop;
            }
            else
            {
                value = default;
            }
            return value;
        }

        protected void Set<T>(T? newValue, [CallerMemberName] string propertyName = "")
        {
            T? oldValue;
            if (_properties.TryGetValue(propertyName, out object? _prop))
            {
                oldValue = (T?)_prop;
            }
            else
            {
                oldValue = default;
            }
            _properties[propertyName] = newValue;
            Set(ref oldValue, newValue, propertyName);
        }

        public virtual void Dispose() { }
    }
}
