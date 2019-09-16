using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.AbstractProduct;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConcreteBibliographyPageProduct : AbstractPageProduct
    {
        public ConcreteBibliographyPageProduct()
        {
        }

        public ConcreteBibliographyPageProduct(string pageColor, 
            PageSize pageSize, SecurityLevel securityLevel) 
            : base(pageColor, pageSize, securityLevel)
        {
        }
    }
}
