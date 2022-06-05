using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyserProblem.POCO
{
   public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;
        }
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }
        //public CensusDTO(USCensusDAO usCensusDAO)
        //{
        //    this.stateCode = usCensusDAO.stateCode;
        //    this.stateCode = usCensusDAO.stateCode;
        //    this.population = usCensusDAO.population;
        //    this.housingDensity = usCensusDAO.housingDensity;
        //    this.totalArea = usCensusDAO.totalArea;
        //    this.waterArea = usCensusDAO.waterArea;
        //    this.landArea = usCensusDAO.landArea;
        //    this.populationDensity = usCensusDAO.populationDensity;
        //    this.housingDensity = usCensusDAO.housingDensity;
        //}
    }
}
