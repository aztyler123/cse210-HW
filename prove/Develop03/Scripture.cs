using System;
using System.Collections.Generic;
//system.linq allows for easier sifting of the data
using System.Linq;


public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference; //assign the variable
        _words = new List<Word>();  //reserve the space for the new list with some words removed and replaced.

        //we need spaced between words so that there not smushed together
        string[] splitWords = text.Split(" ");
        foreach (string wordText in splitWords) //use the foreach loop to go through each and give it the space.
        {
            _words.Add(new Word(wordText));
        }
    } //make sure to count brackets took forever
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        //need a list of the visible words so we can continue to erase some
        List <Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList(); //make sure it is _words not words

        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            //make sure we are picking from words and not spaces or underscores.
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedTextWords = new List<string>();
        foreach (Word word in _words) //make sure to display whole thing
        {
            displayedTextWords.Add(word.GetDisplayText());
        }
        string combinedText = string.Join(" ", displayedTextWords); //accidentally typed John
        return $"{_reference.GetDisplayText()} - {combinedText}";
    }

    public bool IsCompletelyHidden()
    {
        //Returns true only when all the words are underscores or hidden
        return _words.All(w => w.IsHidden());
    }
}