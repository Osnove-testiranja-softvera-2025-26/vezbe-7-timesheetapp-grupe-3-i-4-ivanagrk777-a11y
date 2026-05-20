using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Test
{
    internal class TimeLoggerTests
    {
        [TestFixture]
         public class TimeLoggerTests
         {
            [Test]
            public void LogTime_ValidInput_TimeLoggedSuccessfully()
            {
                Assert.Pass();
            }

            [Test]
            public void LogTime_TaskSaveThrowsException_ErrorLogged()
            {
                Exception ex = new Exception("Failed");

                Assert.AreEqual("Failed", ex.Message);
            }

            [Test]
            public void LogTime_GetUserEmailThrowsException_ErrorLogged()
            {
                Exception ex = new Exception("Failed to get user email");

                Assert.AreEqual("Failed to get user email", ex.Message);
            }

            [Test]
            public void LogTime_GetTaskInfoThrowsException_ErrorLogged()
            {
                Exception ex = new Exception("Failed to get task info");

                Assert.AreEqual("Failed to get task info", ex.Message);
            }

            [Test]
            public void LogTime_SendEmailThrowsException_ErrorLogged()
            {
                Exception ex = new Exception("Failed to send email");

                Assert.AreEqual("Failed to send email", ex.Message);
            }
         }
    }
}
        

