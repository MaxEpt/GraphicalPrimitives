namespace GraphicalPrimitives
{
    public abstract class GraphicalPrimitive
    {
        protected IDoubleCompareService _doubleCompareService;

        public GraphicalPrimitive()
        {
            _doubleCompareService = new DefaultDoubleCompareService();
        }

        public GraphicalPrimitive(IDoubleCompareService doubleComparerService)
        {
            _doubleCompareService = doubleComparerService;
        }            

        public abstract double CalculateArea();
    }
}