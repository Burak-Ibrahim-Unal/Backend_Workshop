#  Calculation of the current state of the two sides (black and white) according to the pieces on the chessboard.

**1.** Checking whether a piece is under threat occurs when there is one or more pieces of the opposite color that threaten that piece.
**2.** Table 1 Chess Pieces In Table 1, the points of the pieces are given. If a piece is not threatened, it gets the score on the table.
**3.** If a piece is threatened by any of the opponent's pieces, the threatened piece's score is half its score in Table 1.


 - Pawn p 1
 - Knight a 3
 - Bishop f 3
 - Rook k 5
 - Queen v 9
 - King s 100
 - Empty xx
 - White color b, Black color s
 - For example Black Rook = ks , White Queen = vs

*Example Chess Board...*
xx xx xx ks xx xx xx ss
xx ps kb xx xx xx fs xx
ps xx xx xx xx xx pb ps
xx xx xx fb xx xx xx xx
xx xx xx as pb xx xx xx
xx pb xx sb xx xx xx xx
pb xx xx xx ab vs xx xx
xx xx xx xx xx xx xx kb

Note: Chess board will be readen from text document.