-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01/09/2023 às 22:23
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `atendente`
--

CREATE TABLE `atendente` (
  `id` int(11) NOT NULL,
  `Nome_ver` varchar(100) NOT NULL,
  `Idade_ver` tinyint(4) DEFAULT NULL,
  `CPF_ver` varchar(11) NOT NULL,
  `Sexo_ver` enum('M','F') NOT NULL,
  `usuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `atendente`
--

INSERT INTO `atendente` (`id`, `Nome_ver`, `Idade_ver`, `CPF_ver`, `Sexo_ver`, `usuario`) VALUES
(1, 'Natanael de Paula', 23, '33132321834', 'M', NULL),
(2, 'Peterson Silva', 20, '12245576303', 'M', NULL),
(3, 'Luis Felipe Cunha', 18, '41398185817', 'M', NULL);

-- --------------------------------------------------------

--
-- Estrutura para tabela `pacientes`
--

CREATE TABLE `pacientes` (
  `id` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `CPF` varchar(11) NOT NULL,
  `Senha` varchar(20) NOT NULL,
  `Idade` tinyint(4) DEFAULT NULL,
  `Sexo` enum('M','F') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `pacientes`
--

INSERT INTO `pacientes` (`id`, `Nome`, `CPF`, `Senha`, `Idade`, `Sexo`) VALUES
(1, 'Natanael de Paula', '33132321834', '40028922', 23, 'M'),
(2, 'Peterson Silva', '12245576303', '8026', 20, 'M'),
(3, 'Luis Felipe Cunha', '41398185817', '3412', 18, 'M');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `atendente`
--
ALTER TABLE `atendente`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuario` (`usuario`);

--
-- Índices de tabela `pacientes`
--
ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `atendente`
--
ALTER TABLE `atendente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `pacientes`
--
ALTER TABLE `pacientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `atendente`
--
ALTER TABLE `atendente`
  ADD CONSTRAINT `atendente_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `pacientes` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
