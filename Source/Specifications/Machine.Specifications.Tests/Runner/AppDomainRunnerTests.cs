﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications.Example;
using Machine.Specifications.Model;
using Machine.Testing;
using NUnit.Framework;

namespace Machine.Specifications.Runner
{
  public class when_running_specs 
  {
    static TestListener listener;
    static AppDomainRunner runner;

    Establish context = () =>
    {
      listener = new TestListener();
      runner = new AppDomainRunner(listener);
    };

    Because of = () => 
      runner.RunAssembly(typeof(Account).Assembly);

    It should_run_them_all = () => 
      listener.SpecCount.ShouldEqual(6);
  }

  public class TestListener : ISpecificationRunListener
  {
    public int SpecCount = 0;
    public void OnAssemblyStart(AssemblyInfo assembly)
    {
    }

    public void OnAssemblyEnd(AssemblyInfo assembly)
    {
    }

    public void OnRunStart()
    {
    }

    public void OnRunEnd()
    {
    }

    public void OnContextStart(ContextInfo context)
    {
    }

    public void OnContextEnd(ContextInfo context)
    {
    }

    public void OnSpecificationStart(SpecificationInfo specification)
    {
    }

    public void OnSpecificationEnd(SpecificationInfo specification, SpecificationVerificationResult result)
    {
      SpecCount++;
    }
  }
}