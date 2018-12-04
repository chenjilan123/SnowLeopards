//Ref: https://docs.microsoft.com/zh-cn/dotnet/standard/events/observer-design-pattern

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.DesignPattern
{
    /// <summary>
    /// A provider or subject, which is the object that sends notifications to observers. 
    /// A provider is a class or structure that implements the IObservable<T> interface. 
    /// The provider must implement a single method, IObservable<T>.Subscribe, 
    /// which is called by observers that wish to receive notifications from the provider.
    /// </summary>
    public class Subject : IObservable<int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="observer"></param>
        /// <returns>An IDisposable implementation that enables the provider to remove observers 
        /// when notification is complete.</returns>
        public IDisposable Subscribe(IObserver<int> observer)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// An observer, which is an object that receives notifications from a provider. 
    /// An observer is a class or structure that implements the IObserver<T> interface.
    /// </summary>
    public class Observer : IObserver<int>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(int value)
        {
            throw new NotImplementedException();
        }
    }
}
