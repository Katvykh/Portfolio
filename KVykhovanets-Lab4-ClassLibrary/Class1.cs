using KVykhovanets_Lab4_ClassLibrary.StateInfoDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVykhovanets_Lab4_ClassLibrary
{
    //Katherine Vykhovanets
    //CPT 206
    //Lab 4 Class Library
    public class State_Class : StateInfoDBDataSet
    {
        private OleDbConnection connection;
        public State_Class()
        {
            connection = new OleDbConnection();

        }

        //properties
        public string State { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public string Flag { get; set; }
        public string Flower { get; set; }
        public string Bird { get; set; }
        public string Colors { get; set; }
        public string Cities { get; set; }
        public decimal MedIncome { get; set; }
        public decimal PercCompJobs { get; set; }

        //constructor
        public State_Class(string state, string capital, int population, string flag, string flower, string bird, string colors, string cities, decimal medIncome, decimal percCompJobs)
        {
            State = state;
            Capital = capital;
            Population = population;
            Flag = flag;
            Flower = flower;
            Bird = bird;
            Colors = colors;
            Cities = cities;
            MedIncome = medIncome;
            PercCompJobs = percCompJobs;
        }

        //sortData method that is called when a radio button is selected and the sort button is clicked
        public static void SortData(StateInfoDBDataSet stateTable,
                             bool sortByStateDesc,
                             bool sortByPop,
                             bool sortByIncome,
                             bool sortByJobPerc,
                             StateTableAdapter stateTableAdapter)
        {
            if (sortByStateDesc)
            {
                stateTableAdapter.FillByStateDesc(stateTable.State);
            }
            else if (sortByPop)
            {
                stateTableAdapter.FillByPopDesc(stateTable.State);
            }
            else if (sortByIncome)
            {
                stateTableAdapter.FillByIncome(stateTable.State);
            }
            else if (sortByJobPerc)
            {
                stateTableAdapter.FillByJobPerc(stateTable.State);
            }
            else //if none of the above selections was made, give the user an error message
            {
                throw new Exception("Please select one of the sorting options above to sort the data.");
            }
        }

        //filterData method that is called when a radio button is selected and the filter button is clicked

        public static void FilterData(StateInfoDBDataSet stateTable,
                             bool noColorFilter,
                             bool colorFilter,
                             bool incomeOver,
                             bool incomeUnder,
                             StateTableAdapter stateTableAdapter)
        {
            if (noColorFilter)
            {
                stateTableAdapter.FillByStatesWithoutColors(stateTable.State);
            }
            else if (colorFilter)
            {
                stateTableAdapter.FillByStatesWithColors(stateTable.State);
            }
            else if (incomeOver)
            {
                stateTableAdapter.FillByIncomeOver70(stateTable.State);
            }
            else if (incomeUnder)
            {
                stateTableAdapter.FillByIncomeUnder70(stateTable.State);
            }
            else//if none of the above selections was made, give the user an error message
            {
                throw new Exception("Please select one of the sorting options above to sort the data.");
            }
        }
    }



}

