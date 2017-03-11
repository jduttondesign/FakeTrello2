using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeTrello.DAL
{
    public interface IRepository
    //list of methods to help deliver features
    //create
    {
        void AddBoard(string name, ApplicationUser owner);
        void AddList(string name, Board board);
        void AddList(string name, int boardId);
        void AddCard(string name, List list, ApplicationUser owner);
        void AddCard(string name, int listId, string ownerid);

        //Read
        List<Card> GetCardsFromList(int listId);
        List<Card> GetCardsFromBoard(int boardId);
        Card GetCard(int cardId);
        List GetList(int listid);
        List<List> GetListsFromBoard(int boardId);
        List<Board> GetBoardsFromUser(string userId);
        List<TrelloUser> GetCardAttendeees(int cardId);

        //Update
        bool AttachedUser(string userId, int cardId);//rue successful, false: not successful
        bool MoveCard(int cardId, int oldListId, int newListId);//tells the backend 
        bool CopyCard(int cardId, int newListId, string newOwnerId);//taking the content and putting it somewhere else
        
        
        //Delete
        bool RemoveBoard(int boardId);//bool will tell the front-end that the card has been deleted
        bool RemoveList(int listId);
        bool RemoveCard(int cardId);
    }
}