/*
rasti problemą. Kodėl programos rezultatas nėra toks:
hint: naudok debugerio pagalbą. F10 - step over. F11 - step inside.

Konsolės rezultatas privalo būti:
Kaunas
pats geriausias
Miestas
*/

string apskaiciuotiMiestoReitinga(int miestoReigintas){
    if(miestoReigintas > 3){
        return "geriausias";
    }else{
        return "blogiausias";
    }
}

void start()
{
    Console.WriteLine("Kaunas");   
    string fraze = "pats " + apskaiciuotiMiestoReitinga(2);
    Console.WriteLine(fraze);
}

void end(){
    console.WriteLine("Miestas")
}