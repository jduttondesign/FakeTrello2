using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FakeTrello.Models;

namespace FakeTrello.DAL
{
    public class FakeTrelloRepository : IRepository
    {
        SqlbConnection _trelloConnection;

        public FakeTrelloRepository()//private FakeTrelloContext context; //data member
        {
            _trelloConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public void AddBoard(string name, ApplicationUser owner)
        _trelloConnection.Open();
            
        try
        {
            //var addBoardCommand = new SqlCommand("select * from Boards", _trelloConnection);
            var addBoardCommand = _trelloConnection.CreateCommand();
        addBoardCommand.CommandText = "Insert into Boards(Name, Owner_Id) values(@name, @ownerID)";
            var sqlParameter = new SqlParameter("name, SqlDbType.VarChar");
        nameParameter.Value = name;
            addBoardCommand.Parameters.Add(nameParameter);
            var ownerParameter = new SqlParameter("name, SqlDbType.VarChar");
        ownerParameter.Value = owner.Id;
            addBoardCommand.Parameters.Add(ownerParameter)

           addBoardCommand.ExecuteNonQuery();
        }
        catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            finally    
            {

            _trelloConnection.Close();
            }

        }

    public Board GetBoard(int boardId)
{
    _trelloConnection.Open();

    try
    {
        var getBoardCommand = _treeloConnection.CreateCommand();
        getBoardCommand.CommandText = @"
        SELECT boardId, Name, Url, Owner_Id 
        FROM Boards 
        WHERE BoardId = @boardId";

        var boardId = new SqlParameter("boardId", SqlDBType.Int);
        boardIdParam.Value = boardId;
        getBoardCommand.Parameters.Add(boardIdParam);

        var reader = getBoardCommand.ExecuteReader();

        if (reader.Read())//says get me the row of data 
        {
            var board = new Board();
            board.BoardId = reader.GetInt32(0);//gets back the value on the board
            board.Name = reader.GetString(1);
            board.URL = reader.GetString(2);
            board.Owner = new ApplicataionUser { Id = reader.GetString(3) };
        };
       return board;
    }
}
catch(Execption ex) {}
finally
{
    _trelloConnection.Close();
}

return_null;

    }

    public List<Board> GetBoardsFromUser(string userId)
{

    _trelloOpen();
    try
}
    var getBoardCommand = _trelloConnection.CreateCommand();
    getBoardCommand.CommandText = @"
    SELECT boardId , Name, Url, Owner_Id
    FROM Boards
    WHERE Owner_Id = @userId;";

    var boardIdParam = new SqlParameter("userId", SqlDbType.VarChar);
    boardIdParam.Value = userId;
    getBoardCommand.Parameters.Add(boardIdParam);

    var reader = getBoardCommand.ExecuteReader();

    var boards = new List<Board>();

    while (reader.Read())
    {
        var board = new Board();
        { 
        board.BoardId = reader.GetInt32(0);//gets back the value on the board
        board.Name = reader.GetString(1);
        board.URL = reader.GetString(2);
        board.Owner = new ApplicataionUser { Id = reader.GetString(3) };
    };
        boards.Add(board);
}
    return boards;
    {

    }

    }

      try
      {
        var addBoardCommand = _trelloConnection.CreateCommand();
        addBoardCommand.CommandText = @"
        Delete
        From Boards
        Where boardsId = @boardId";
        var boardIdParameter = new SqlParameter("boardId", SqlDbType.Int);
        boardIdParameter.Value = boardId;
        addBoardCommand.Parameters.Add(boardIdParameter);

    removeBoardCommand.ExecuteNonQuery();

    return true;

    catch (SqlException ex)
    {
    Debug.WriteLine(ex.Message);
    Debug.WriteLine();
   
        }


     _trelloOpen();
    try
}
    var getBoardCommand = _trelloConnection.CreateCommand();
    getBoardCommand.CommandText = @"
    Update Boards 
    Set Name = @NewName;
    Where boardId = @boardId";
    var nameParameter = new SqlParameter("Newname", SqlDbType.VarChar);
    nameParameter.Value = newname;
    updateBoardcommand.Parameters.Add(nameParameter);
    var boardIdParameter = new SqlParameter("boardId", SqlDbType.Int);
    
    getBoardCommand.Parameters.Add(boardIdParameter);


    var reader = getBoardCommand.ExecuteReader();

var boards = new List<Board>();
    }

}