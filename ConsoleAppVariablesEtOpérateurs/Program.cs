namespace ConsoleAppVariablesEtOpérateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal complementaireSanté, viellesse, retraiteComplementaire, contributionDequilibreGénéral, csgDéductible, csgNonDéductible, crds, salaireBrut, totalCotisationsSalariales, maladie, accidentsTravail, allocationsFamiliales, formationProfessionnelle, assuranceChômage, contributionAuFondsNational, cotisationsAuRégimeDeGarantieDesSalaires, cotisationsAuFondsNationalDAssuranceVieillesse, cotisationsAuFondsNationalDAssuranceMaladie, cotisationsAuFondsNationalDaideAuLogement, cotisationAuRégimeDeGarantieDesSalaires, tauxDapprentissage, contributionAuDialogueSocial, exonérationCotisationsPatronales, totalCotisationsPatronale, montantTotalEmployeur;
            Console.WriteLine("Entrez votre Nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre Prénom");
            string prénom = Console.ReadLine();
            Console.WriteLine("Entrez le mois");
            string mois = Console.ReadLine();
            Console.WriteLine("Nombre d'heure travaillées");
            decimal heuresTravaillées = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Taux d'horaire");
            decimal tauxHoraire = decimal.Parse(Console.ReadLine());

            salaireBrut = heuresTravaillées * tauxHoraire;
            complementaireSanté = salaireBrut * 0.0107m;
            viellesse = salaireBrut * 0.073m;
            retraiteComplementaire = salaireBrut * 0.03m;
            contributionDequilibreGénéral = salaireBrut * 0.01m;
            csgDéductible = salaireBrut * 0.068m;
            csgNonDéductible = salaireBrut * 0.02m;
            crds = salaireBrut * 0.005m;
            totalCotisationsSalariales = complementaireSanté + viellesse + retraiteComplementaire + contributionDequilibreGénéral + csgDéductible + csgNonDéductible + crds * 0.01m;
           
            decimal totalRetenues = complementaireSanté + viellesse + retraiteComplementaire + contributionDequilibreGénéral + csgDéductible + csgNonDéductible + crds;
            decimal salaireNet = salaireBrut - totalRetenues;
           
            Console.WriteLine($"*** Fiche de Paye de {prénom} {nom} pour le mois de {mois} ***");
            Console.WriteLine($"Salaire brut : {salaireBrut}");
           
            Console.WriteLine($"Cotisations salariales :");

            Console.WriteLine($"Complémentaire santé : {complementaireSanté}");                  
            Console.WriteLine($"CSG déductible : {csgDéductible}");
            Console.WriteLine($"CSG non déductible : {csgNonDéductible}");
            Console.WriteLine($"CRDS : {crds}");
            Console.WriteLine($"Total cotisations salariales : {totalCotisationsSalariales}");

            Console.WriteLine($"Cotisations patronales :");
           
            Console.WriteLine($"Complémentaire santé : {complementaireSanté * 0.01m}");
            Console.WriteLine($"Maladie : {salaireBrut * 0.13m}");
            Console.WriteLine($"Accidents du travail et maladies professionnelles : {salaireBrut * 0.01m}");
            Console.WriteLine($"Vieillesse : {viellesse}");
            Console.WriteLine($"Retraite complémentaire : {retraiteComplementaire}");
            Console.WriteLine($"Contribution d'équilibre général : {contributionDequilibreGénéral}");
            Console.WriteLine($"Allocations familiales : {salaireBrut * 0.05m}");
            Console.WriteLine($"Contribution  au Fonds National d'Aide au Logement : {salaireBrut * 0.01m}");
            Console.WriteLine($"Assurance chômage : {salaireBrut * 0.04m}");
            Console.WriteLine($"Cotisations au régime de garantie des salaires : {salaireBrut * 0.01m}");
            Console.WriteLine($"Formation professionnelle : {salaireBrut * 0.01m}");
            Console.WriteLine($"Taux d'apprentissage : {salaireBrut * 0.01m}");
            Console.WriteLine($"Contribution au dialogue social : {salaireBrut * 0.01m}");
          
            Console.WriteLine($"Exonération de cotisations patronales : {salaireBrut * 0.01m}");
            
            Console.WriteLine($"Salaire net : {salaireNet}");

        }
                 
    }

 }