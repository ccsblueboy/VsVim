﻿#light

namespace Vim.Modes.Command
open Vim
open Vim.Modes
open Microsoft.VisualStudio.Text
open System.Text.RegularExpressions

type internal CommandProcessor = 
    new : IVimBuffer * ICommonOperations * IOperations * IFileSystem * IFoldManager -> CommandProcessor

    interface ICommandProcessor
