using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using MyCode.Core.Scope;
using MyCode.Core.InputService;

namespace MyCode.Core.Installers
{
    public class InputServiceInstaller : MonoInstaller
    {
        [SerializeField] private bool _isPc;
        [SerializeField] private MobileInputService _mobileInputService;

        public override void Install(IContainerBuilder builder)
        {
            /*BaseInputService inputService;
            if (_isPc)
                inputService = new PcInputService();
            else
            {
                if (_mobileInputService == null)
                    throw new NullReferenceException("Mobile Input Service is null");

                _mobileInputService = Instantiate(_mobileInputService);
                inputService = _mobileInputService;
            }

            builder.RegisterInstance<IInputService, ITickable>(inputService);*/
        }
    }
}