using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser.POCO
{
    public class CensusDataDAO
    {
        public string state;
        public long population;
        public long area;
        public long density;

        /// <summary>
        /// This Parameterized Constructor Initializes a new instance of this class.
        /// </summary>
        /// <param name="state"> State.</param>
        /// <param name="population"> Population.</param>
        /// <param name="area"> Area.</param>
        /// <param name="density"> Density.</param>
        public CensusDataDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToInt32(population);
            this.area = Convert.ToInt32(area);
            this.density = Convert.ToInt32(density);
        }
    }
}
