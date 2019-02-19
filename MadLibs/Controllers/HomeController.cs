using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlibs")]
    public ActionResult MadLibs(string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.SetPerson1(person1);
      myMadLibsVariable.SetPerson2(person2);
      myMadLibsVariable.SetAnimal(animal);
      myMadLibsVariable.SetExclamation(exclamation);
      myMadLibsVariable.SetVerb(verb);
      myMadLibsVariable.SetNoun(noun);

      return View(myMadLibsVariable);
    }
  }
}
