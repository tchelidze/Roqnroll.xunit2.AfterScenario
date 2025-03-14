using Reqnroll;

namespace Roqnroll.xunit2.AfterScenario.StepDefinitions;

[Binding]
public class RegistrationStepDefinitions
{
    [Given("sample given")]
    public void GivenThereIsAUserRegisteredWithUserNameAndPassword(string userName, string password)
    {
    }

    [When("sample when")]
    public void WhenTheUserAttemptsToRegisterWithUserNameAndPassword(string userName, string password)
    { }

    [Then("sample then")]
    public void ThenTheRegistrationShouldBeSuccessful()
    { }
}