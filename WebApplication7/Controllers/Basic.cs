using System;
using System.Collections.Generic;

namespace WebApplication7.Controllers
{
    public class Basic
    {
        public static Dictionary<string, IBaseProcessor>BaseProcessors=new Dictionary<string, IBaseProcessor>();

        public Basic()
        {
        }
    }        
}