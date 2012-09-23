USE [AgendaFW2GSG37571]
GO

SELECT Agendamentos.id
	  , Pessoas.nome as nome
	  , ta.nome as tarefa
	  , lo.nome as local
      ,[data]
  FROM [dbo].[Agendamentos] INNER JOIN Pessoas On Pessoas.id = Agendamentos.id LEFT JOIN Tarefas as Ta 
  On Agendamentos.id_tarefas = Ta.id INNER JOIN Locais as Lo On Lo.id = Agendamentos.id_locais 
  
GO


