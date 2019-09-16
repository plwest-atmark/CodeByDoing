using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.AbstractFactory;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteProduct;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteFactory
{
    /// <summary>
    /// A 'ConcreteFactory' class
    /// </summary>
    class ConcreteReportFactory : AbstractFactory.AbstractDocumentFactory
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new ConcreteIntroductionPageProduct());
            Pages.Add(new ConcreteResultsPageProduct());
            Pages.Add(new ConcreteConclusionPageProduct());
            Pages.Add(new ConcreteSummaryPageProduct());
            Pages.Add(new ConcreteBibliographyPageProduct());
        }
    }
}
