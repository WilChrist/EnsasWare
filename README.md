# EnsasWare
Vous avez ici le template de base du projet. Chacun de nous doit : 
 - Pull la devbranch;
 - créer un UserControl dans les dimensions du GridMain
 - faire sa partie dans un UserControl

Pour ajouter vos UserControl, il suffit:
 * ajouter ces lignes dans le case correspondant :
    GridMain.Children.Clear();
    GridMain.Children.Add(new LoginControl()); // LoginControl c'est le nom de mon UserControl par exemple et ça correspond au case 0
    
Je vous dirait comment ajouter votre UserControl au reste par la suite.
