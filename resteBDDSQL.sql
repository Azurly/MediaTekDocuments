/* Création de la table Suivi, pour la suivi des commandes*/

CREATE TABLE Suivi (
    IDSuivi INT PRIMARY KEY,
    IDCommande INT,
    Etape VARCHAR(255),
    DateSuivi DATE,
    Commentaire TEXT,
    FOREIGN KEY (IDCommande) REFERENCES CommandeDocument(IDCommande)
);

