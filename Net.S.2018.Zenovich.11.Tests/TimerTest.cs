using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Net.S._2018.Zenovich._11.Time;
using Net.S._2018.Zenovich._11.Time.Interfaces;
using Timer = Net.S._2018.Zenovich._11.Time.Timer;

namespace Net.S._2018.Zenovich._11.Tests
{
    [TestClass]
    public class TimerTest
    {
        public TestContext TestContext { get; set; }

        private bool isFirstCallbackRun;
        private bool isSecondCallbackRun;

        [TestMethod]
        public void TimerEvent_EventWasCalled()
        {
            isFirstCallbackRun = false;
            isSecondCallbackRun = false;

            ITimer timer = new Timer(TimeSpan.FromMilliseconds(500));
            timer.TimerEvent += FirstCallback;
            timer.TimerEvent += SecondCallback;
            Thread.Sleep(600);

            if (!isFirstCallbackRun || !isSecondCallbackRun)
            {
                throw new Exception();
            }
            
        }

        public void FirstCallback(object sender, TimerEventArgs eventArgs)
        {
            TestContext.WriteLine("FirstCallback");
            TestContext.WriteLine($"Sender: {sender}");
            TestContext.WriteLine($"DateTime: {eventArgs.DateTime}");
            TestContext.WriteLine($"Message: {eventArgs.Message}");

            isFirstCallbackRun = true;
        }

        public void SecondCallback(object sender, TimerEventArgs eventArgs)
        {
            TestContext.WriteLine("SecondCallback");
            TestContext.WriteLine($"Sender: {sender}");
            TestContext.WriteLine($"DateTime: {eventArgs.DateTime}");
            TestContext.WriteLine($"Message: {eventArgs.Message}");

            isSecondCallbackRun = true;
        }
    }
}
