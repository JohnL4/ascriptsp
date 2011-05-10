using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetprep.utility
{
    public class ComparableMatchFactory<ItemToCreateCriteriaFor, PropertyType> where PropertyType : IComparable<PropertyType>
    {
        PropertyAccessor<ItemToCreateCriteriaFor, PropertyType> accessor;
    
        public ComparableMatchFactory(PropertyAccessor<ItemToCreateCriteriaFor, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatch<ItemToCreateCriteriaFor> greater_than( PropertyType value)
        {
            return new AnonymousCriteria<ItemToCreateCriteriaFor>(
                x => accessor(x).CompareTo(value) > 0
                );
        }
    }
}
