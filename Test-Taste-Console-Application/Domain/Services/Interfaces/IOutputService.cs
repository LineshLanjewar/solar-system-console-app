using Test_Taste_Console_Application.Domain.Objects;

namespace Test_Taste_Console_Application.Domain.Services.Interfaces
{
    ///<summary>
    /// An output service that can show data from the Solar System OpenData API<see href="https://api.le-systeme-solaire.net/"/> to a user via the console. 
    ///</summary>
    public interface IOutputService
    {
        void OutputAllPlanetsAndTheirMoonsToConsole(Planet[] planets);
        void OutputAllMoonsAndTheirMassToConsole();
        void OutputAllPlanetsAndTheirAverageMoonGravityToConsole(Planet[] planets);
        void OutputAllPlanetsAndTheirMoonsAvgTemperature(Planet[] planets);
    }
}
