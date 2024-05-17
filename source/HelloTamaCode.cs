using Triamec.Tama.Rlid19;       // used for register access
using Triamec.Tama.Vmid5;        // used for interpretation of Tama attributes

[Tama]                           // attribute to indicate the starting point for the Tama compiler
static class HelloTama           // name of the tama program
{
    /*****************************************************************
    * isochronous main task
    *****************************************************************/
    // attribute to indicate the entry point
    [TamaTask(Task.IsochronousMain)]
    // main function, (name is not relevant)
    static void MainIso() {
        Register.Application.Variables.Booleans[1] = Register.Application.Variables.Booleans[0];
    }
}
