namespace LangageBrainFuck;

public interface IInterpreteur
{
    void ChargerProgramme(string codeDuProgramme);
    void Executer();
}
