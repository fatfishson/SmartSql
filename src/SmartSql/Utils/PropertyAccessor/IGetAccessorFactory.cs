﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSql.Utils.PropertyAccessor
{
    public class PropertyValue
    {
        public PropertyValue() { }
        public PropertyValue(object val)
        {
            Value = val;
        }
        public GetStatus Status { get; set; } = GetStatus.Ok;
        public object Value { get; set; }

        public enum GetStatus
        {
            Ok = 1,
            NotFindProperty = 1 << 1,
            NotFindGet = 1 << 2
        }
    }
    public interface IGetAccessorFactory
    {
        Func<object, PropertyValue> CreateGet(Type targetType, string propertyName, bool ignorePropertyCase);
    }
}
