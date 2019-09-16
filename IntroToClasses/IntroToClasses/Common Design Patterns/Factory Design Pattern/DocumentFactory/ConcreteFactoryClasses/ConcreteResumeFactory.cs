using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.AbstractFactory;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteProduct;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteFactory
{
    /// <summary>
    /// A 'ConcreteFactory' class
    /// </summary>
    class ConcreteResumeFactory : AbstractFactory.AbstractDocumentFactory
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new ConcreteSkillsPageProduct());
            Pages.Add(new ConcreteEducationPageProduct());
            Pages.Add(new ConcreteExperiencePageProduct());
        }
    }
}
