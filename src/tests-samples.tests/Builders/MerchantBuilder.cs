using tests_samples.core;

namespace tests_samples.tests.Builders
{
    public class MerchantBuilder
    {
        private const string name_default = "name_default";
        private const string coporateName_default = "corporateName_default";
        private const string zipCode_default = "zipCode_default";
        
        private readonly Merchant _merchant = new Merchant();

        public MerchantBuilder WithName(string name =name_default)
        {
            this._merchant.Name = name;
            return this;
        }

        public MerchantBuilder WithCorporateName(string corporateName = coporateName_default)
        {
            this._merchant.CorporateName = corporateName;
            return this;
        }

        public MerchantBuilder WithZipCode(string zipCode = zipCode_default)
        {
            this._merchant.ZipCode = zipCode;
            return this;
        }

        public MerchantBuilder WithDefault()
        {
            this._merchant.Name = name_default;
            this._merchant.CorporateName = coporateName_default;
            this._merchant.ZipCode = zipCode_default;
            return this;
        }
        
        public Merchant Build()
        {
            return this._merchant;
        }
        
        public static MerchantBuilder Instance()
        {
            return new MerchantBuilder();
        }
    }
}