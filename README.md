# EnsasWare
Vous avez ici le template de base du projet. Chacun de nous doit : 
 - Pull la devbranch;
 - créer un UserControl dans les dimensions du GridMain
 - faire sa partie dans un UserControl

Pour ajouter vos UserControl, il suffit:
 * ajouter ces lignes dans le case correspondant (MainWindow.waml.cs):

    GridMain.Children.Clear();
    
    GridMain.Children.Add(new LoginControl()); // LoginControl c'est le nom de mon UserControl par exemple et ça correspond au case 0
    
Dans le XAML il faut entourer la grid principal de votre UserControl par cette balise
    <materialDesign:TransitioningContent x:Name="TrainsitionigContentSlide" OpeningEffect="{materialDesign:TransitionEffect SlideInFromTop, Duration=0:0:0.5}">
        </materialDesign:TransitioningContent>


