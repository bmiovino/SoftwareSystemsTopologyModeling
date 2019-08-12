using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSystemsTopologyModeling
{
    public interface ISourceBase
    {

    }

    public class ExternalSource : ISourceBase
    {

    }

    public class InternalSource : ISourceBase
    {

    }

    public interface ISinkBase
    {

    }

    public class InternalSink : ISinkBase, IInfoUtilization
    {

    }

    public class ExternalSink : ISinkBase, IInfoUtilization
    {

    }

    public interface IInfoUnion
    {

    }

    public interface IInfoAddition
    {

    }

    public interface IInfoSubtraction
    {

    }

    public interface IInfoTransformation
    {

    }

    public interface IInfoUtilization
    {

    }

    public interface IRelay
    {

    }

    public class PersistentRelay : IRelay, IStorage, IPersistent
    {

    }

    public class TransientRelay : IRelay, IStorage, ITransient
    {

    }

    public interface IStorage
    {

    }

    public interface IPersistent
    {

    }

    public interface ITransient
    {

    }

    public interface IOneToOne
    {

    }

    public interface IOneToMany
    {

    }

    public class Distributor : IRelay, IOneToMany
    {

    }

    public class Process : IInfoUnion, IInfoAddition, IInfoSubtraction, IInfoTransformation, IInfoUtilization, ISinkBase
    {

    }

    public class PersistentStore : IStorage, IPersistent
    {

    }

    public class TransientStore : IStorage, ITransient
    {

    }

    public class Queue : IStorage, ITransient, IRelay
    {

    }

    public class MessageBus : Distributor, IStorage, ITransient
    {

    }
}
