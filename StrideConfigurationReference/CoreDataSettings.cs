using Stride.Core;
using Stride.Core.Annotations;
using Stride.Core.Reflection;
using Stride.Core.Serialization;
using Stride.Data;
using Stride.Engine;
using System;

namespace StrideConfigurationReference
{
    [DataContract]
    [Display("Game.Core")]
    [ObjectFactory(typeof(CoreDataSettingsFactory))]
    public class CoreDataSettings : Configuration
    {
        public Prefab TestPrefab { get; set; }
    }

    public class CoreDataSettingsFactory : IObjectFactory
    {
        public object New(Type type)
        {
            return new CoreDataSettings();
        }
    }
}
