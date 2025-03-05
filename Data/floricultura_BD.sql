CREATE DATABASE floriculturaFlorescer;
USE floriculturaFlorescer;
    
CREATE TABLE Clientes (
	idCliente INT PRIMARY KEY AUTO_INCREMENT,
	nomeCliente VARCHAR(80) NOT NULL,
	telefone VARCHAR(20),
	email VARCHAR(50),
	cpf  VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Funcionarios (
	idFuncionario INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(80) NOT NULL,
	telefone VARCHAR(20),
	email VARCHAR(50),
	cpf  VARCHAR(20) NOT NULL UNIQUE,
    dataAdmissao DATE
);

CREATE TABLE Fornecedores (
	idFornecedor INT PRIMARY KEY AUTO_INCREMENT,
    nomeFantasia VARCHAR(80) NOT NULL,
    razaoSocial VARCHAR(80),
    cnpj VARCHAR(20) NOT NULL UNIQUE,
    telefone VARCHAR(20),
    email VARCHAR(80)
);

CREATE TABLE Produtos (
	idProduto INT PRIMARY KEY AUTO_INCREMENT,
    nomeProduto VARCHAR(80) NOT NULL,
    categoria VARCHAR(80),
    descricao TEXT,
    preco DOUBLE,
    undProduto VARCHAR(20),
    fkidFornecedor INT NOT NULL,
    FOREIGN KEY (fkidFornecedor) REFERENCES Fornecedores (idFornecedor)
);

CREATE TABLE Estoques (
	idEstoque INT PRIMARY KEY AUTO_INCREMENT,
    qtd INT,
    fkidProduto INT NOT NULL,
    FOREIGN KEY (fkidProduto) REFERENCES Produtos (idProduto)
);
    
CREATE TABLE Pedidos (
	idPedido INT PRIMARY KEY AUTO_INCREMENT,
    descricao TEXT,
    formaPgt VARCHAR(20),
    valorTotal DOUBLE,
    dataPedido DATE,
    fkidCliente INT NOT NULL,
    FOREIGN KEY (fkidCliente) REFERENCES Clientes (idCliente)
);

CREATE TABLE ItensPedido(
	idItensPedido INT PRIMARY KEY AUTO_INCREMENT,
    qtdItens INT,
    precoUnitario DOUBLE,
    fkidProduto INT NOT NULL,
    fkidPedido INT NOT NULL,
    FOREIGN KEY (fkidProduto) REFERENCES Produtos (idProduto),
    FOREIGN KEY (fkidPedido) REFERENCES Pedidos (idPedido)
);

INSERT INTO Fornecedores(nomeFantasia, razaoSocial, cnpj, telefone, email) VALUES
("Floricultura Viva", "Floricultura Viva LTDA", "12.345.678/0001-90",
"(69) 99345-7894", "contato@floriculturaviva.com");

INSERT INTO Fornecedores(nomeFantasia, razaoSocial, cnpj, telefone, email) VALUES
("Jardim Encantado", "Jardim Encantado LTDA", "23.456.789/0001-80",
"(21) 99876-5432", "vendas@jardimencantado.com");

INSERT INTO Fornecedores(nomeFantasia, razaoSocial, cnpj, telefone, email) VALUES
("Flores do Campo", "Flores do Campo Comércio de Plantas LTDA", "45.123.456/0001-90",
"(11) 98765-4321", "contato@floresdocampo.com");

INSERT INTO Produtos (nomeProduto, categoria, descricao, preco, undProduto, fkidFornecedor) VALUES 
("Terra Adubada", "Adubos e Fertilizantes", "Terra com adubo orgânico", 15.00, "Kg", 1);

INSERT INTO Produtos (nomeProduto, categoria, descricao, preco, undProduto, fkidFornecedor) VALUES 
("Lírios Brancos", "Flores e Arranjos", "Lírios perfumados brancos", 50.00, "Unidade", 2);

INSERT INTO Produtos (nomeProduto, categoria, descricao, preco, undProduto, fkidFornecedor) VALUES 
("Rosas Vermelhas", "Flores e Arranjos", "Arranjo de rosas vermelhas frescas", 60.00, "Unidade", 3);

SELECT * FROM Produtos;
SELECT * FROM Fornecedores;

