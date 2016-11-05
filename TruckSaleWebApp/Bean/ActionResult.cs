using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Bean
{
    public delegate object WorkerRunner();
    public class ActionResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public object Result { get; set; }

        public ActionResult()
        {
            IsSuccess = true;
            Message = "";
        }

        public ActionResult(WorkerRunner runner) : base()
        {
            IsSuccess = true;
            Message = "";
            Execute(runner);
        }

        public void Execute(WorkerRunner runner)
        {
            try
            {
                Result = runner.Invoke();
            }
            catch (Exception e)
            {
                IsSuccess = false;
                Message = e.Message;
            }
        }
 
    }
}