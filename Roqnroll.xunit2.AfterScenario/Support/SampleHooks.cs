using Reqnroll;
using System.Threading.Tasks;
using System;

namespace Roqnroll.xunit2.AfterScenario.Support;

[Binding]
public static class SampleHooks
{
    [AfterTestRun]
    public static async Task AfterAllTests2(ITestRunnerManager testRunnerManager)
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        
        // this line is never reached
        await Task.Delay(TimeSpan.FromSeconds(2));
    }

}