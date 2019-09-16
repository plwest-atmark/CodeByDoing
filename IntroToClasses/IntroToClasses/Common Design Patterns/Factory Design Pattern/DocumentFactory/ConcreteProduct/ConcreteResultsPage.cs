using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.AbstractProduct;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteResultsPageProduct : AbstractPageProduct
    {
        public ConcreteResultsPageProduct()
        {
        }

        public ConcreteResultsPageProduct(string pageColor,
            PageSize pageSize, SecurityLevel securityLevel)
            : base(pageColor, pageSize, securityLevel)
        {
        }
    }
}
