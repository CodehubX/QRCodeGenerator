﻿Imports System

Namespace Ys.QRCode.Format

    ''' <summary>
    ''' 構造的連接
    ''' </summary>
    Friend Module StructuredAppend

        ' 構造的連接ヘッダーのビット数
        Public Const HEADER_LENGTH As Integer = ModeIndicator.LENGTH +
                                                SymbolSequenceIndicator.POSITION_LENGTH +
                                                SymbolSequenceIndicator.TOTAL_NUMBER_LENGTH +
                                                PARITY_DATA_LENGTH

        ' パリティデータのビット数
        Public Const PARITY_DATA_LENGTH As Integer = 8
        
    End Module

End Namespace