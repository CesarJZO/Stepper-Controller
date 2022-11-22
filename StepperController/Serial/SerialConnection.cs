using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace StepperController.Serial
{
    public class SerialConnection
    {
        public event EventHandler<string> OnStep;
        private readonly SerialPort _port;

        public SerialConnection()
        {
            _port = new SerialPort("COM6", 9600);

            _port.Open();
            Initialize();
        }

        public void SendMessage(string message)
        {
            if (_port.IsOpen)
                _port.Write(message);
        }
        
        private void Initialize()
        {
            var dueTime = TimeSpan.FromSeconds(1);
            var interval = TimeSpan.FromSeconds(0.012);
            
#pragma warning disable CS4014
            RunPeriodicAsync(dueTime, interval, CancellationToken.None);
#pragma warning restore CS4014
        }

        private async Task RunPeriodicAsync(TimeSpan dueTime, TimeSpan interval, CancellationToken token)
        {
            // Initial wait time before we begin the periodic loop.
            if(dueTime > TimeSpan.Zero)
                await Task.Delay(dueTime, token);

            // Repeat this loop until cancelled.
            while(!token.IsCancellationRequested)
            {
                // Call our onTick function.
                OnStep?.Invoke(this, _port.ReadExisting());
                
                // Wait to repeat again.
                if(interval > TimeSpan.Zero)
                    await Task.Delay(interval, token);       
            }
        }
    }
}
