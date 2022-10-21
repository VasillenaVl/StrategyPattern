using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Conceptual
{
 
    class Context
    {
     
        private ISite _strategy;

        public Context()
        { }

        public Context(ISite strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(ISite strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine(this._strategy.CreateSite());
        }
    }

    
    public interface ISite
    {
        string CreateSite();
    }

    class StaticSite : ISite
    {
        public string CreateSite()
        {
            return "static"; 

        }
    }

    class DynamicSite : ISite
    {
        public string CreateSite()
        {
            
           return "dynamic";
         
        }
    }
    class ResponsiveSite : ISite
    {
        public string CreateSite()
        {
           return "responsive";
         
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var Context = new Context();

            Console.WriteLine("Site is set to static.");
            Context.SetStrategy(new StaticSite());
            Context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Site is set to dynamic.");
            Context.SetStrategy(new DynamicSite());
            Context.DoSomeBusinessLogic();
            
            Console.WriteLine();

            Console.WriteLine("Site is set to responsive.");
            Context.SetStrategy(new ResponsiveSite());
            Context.DoSomeBusinessLogic();
        }
    }
}