using System;

namespace LangageBrainFuck
{
    public interface IInterpreteur : IObservable<InterpreteurEvent>
    {
        void ChargerProgramme(string codeDuProgramme);
        void Executer();
        void Reinitialiser(bool p_deboguage);
        void ExecuterUneInstruction();
    }
}