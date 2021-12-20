﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.ChessPieces
{
    public class Pawn : ChessPiece
    {
        public override int ValuePoints => 1;

        public override string FullName => "Pawn";

        public override char Letter => 'P';

        public Pawn(ChessPlayer player, ChessPosition position) : base(player, position) { }

        public override List<ChessPosition> GetMoves()
        {
            int col = Position.Column;
            int row = Position.Row;
            int dir = Player == ChessPlayer.White ? 1 : -1;
            List<ChessPosition> moves = new List<ChessPosition>
            {
                new ChessPosition(col, row + dir * 1)
            };

            if (!Position.IsMoved)
            {
                moves.Add(new ChessPosition(col, row + dir * 2));
            }
            if (col + 1 <= ChessPosition.MaxColumn)
            {
                moves.Add(new ChessPosition(col + 1, row + dir * 1));
            }
            if (col - 1 >= ChessPosition.MinColumn)
            {
                moves.Add(new ChessPosition(col - 1, row + dir * 1));
            }

            return moves;
        }
    }
}