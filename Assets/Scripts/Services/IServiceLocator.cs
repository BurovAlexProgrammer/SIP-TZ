using System;
using System.Collections.Generic;

namespace Services
{
    public interface IServiceLocator<T>
    {
        TP Register<TP>(TP newService) where TP : T;
        void Unregister<TP>(TP service) where TP : T;
        TP Get<TP>() where TP : T;
    }

    public class ServiceLocator<T> : IServiceLocator<T>
    {
        protected Dictionary<Type, T> _serviceMap { get; }

        public ServiceLocator()
        {
            _serviceMap = new Dictionary<Type, T>();
        }
        
        public TP Register<TP>(TP newService) where TP : T
        {
            var type = newService.GetType();
            
            if (_serviceMap.ContainsKey(type))
            {
                throw new Exception($"Service type of '{type}' is already registered.");
            }

            _serviceMap[type] = newService;
            return newService;
        }

        public void Unregister<TP>(TP service) where TP : T
        {
            var type = service.GetType();

            if (_serviceMap.ContainsKey(type))
            {
                _serviceMap.Remove(type);
            }
        }

        public TP Get<TP>() where TP : T
        {
            if (_serviceMap.TryGetValue(typeof(TP), out var service))
            {
                return (TP)service;
            }

            throw new Exception($"Service type of '{typeof(TP)}' not found.");
        }
    }
}