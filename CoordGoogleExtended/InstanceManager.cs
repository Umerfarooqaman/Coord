﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CoordGoogleExtended
{
    public class InstanceManager<T>
    {
        public static readonly Dictionary<string, T> Pool = new Dictionary<string, T>();

        public string CurrentScope { get; set; }
        
        public static T GetInstance()
        {
            return (T)Activator.CreateInstance(typeof(T)); ;
        }

        public static Dictionary<string, T> SharedPool
        {
            set
            {
                var pool = typeof(InstanceManager<T>).GetTypeInfo().DeclaredFields
                    .First(field => field.Name == "Pool");
                pool.SetValue(null, value);



            }
        }

        public static T GetScopedInstance(string scope)
        {
            if (Pool.ContainsKey(scope))
            {
                Pool.TryGetValue(scope, value: out var service);

                var pool = service.GetType().GetTypeInfo().DeclaredFields
                    .First(field => field.Name == "CurrentScope");
                pool.SetValue(null, scope);

                return service;
            }
            else
            {
                T service;
                Pool.Add(scope, service = GetInstance());

                return service;
            }
        }

        public static T GetSingletonInstance()
        {
            return GetScopedInstance("singelton");
        }

    }
}
