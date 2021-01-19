
CREATE TABLE Usuario (
                id BIGINT NOT NULL,
                email CHAR(64) NOT NULL,
                senha VARCHAR(64) NOT NULL,
                nome VARCHAR(64) NOT NULL,
                PRIMARY KEY (id)
);

ALTER TABLE Usuario MODIFY COLUMN senha VARCHAR(64) COMMENT 'SHA256';


CREATE TABLE Estante (
                id BIGINT NOT NULL,
                quantidadeTotalLivros INT NOT NULL,
                usuario_id BIGINT NOT NULL,
                quantidadeDeLivrosLidos INT NOT NULL,
                PRIMARY KEY (id)
);


CREATE TABLE Livro (
                id BIGINT NOT NULL,
                lido BOOLEAN NOT NULL,
                estante_id BIGINT NOT NULL,
                editora VARCHAR(64),
                nome VARCHAR(256) NOT NULL,
                autor VARCHAR(64),
                situacao_de_emprestimo INT,
                PRIMARY KEY (id)
);


CREATE TABLE Emprestimo (
                id BIGINT NOT NULL,
                livro_id BIGINT NOT NULL,
                data_de_emprestimo DATE NOT NULL,
                data_de_devolucao DATE NOT NULL,
                PRIMARY KEY (id)
);


CREATE TABLE ListaDeDesejos (
                id BIGINT NOT NULL,
                livro_id BIGINT NOT NULL,
                usuario_id BIGINT NOT NULL,
                PRIMARY KEY (id)
);

ALTER TABLE ListaDeDesejos MODIFY COLUMN livro_id BIGINT COMMENT 'SHA256';


ALTER TABLE Estante ADD CONSTRAINT usuario_estante_fk
FOREIGN KEY (usuario_id)
REFERENCES Usuario (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE ListaDeDesejos ADD CONSTRAINT usuario_listadedesejos_fk
FOREIGN KEY (usuario_id)
REFERENCES Usuario (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE Livro ADD CONSTRAINT estante_livro_fk
FOREIGN KEY (estante_id)
REFERENCES Estante (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE ListaDeDesejos ADD CONSTRAINT livro_listadedesejos_fk
FOREIGN KEY (livro_id)
REFERENCES Livro (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE Emprestimo ADD CONSTRAINT livro_emprestimo_fk
FOREIGN KEY (livro_id)
REFERENCES Livro (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION;