export const wordWithNoPunctuationExpression = new RegExp(/\b\w+/);

export const wordsWithPunctuationExpression = new RegExp(
  /\b\w+[!'\\#$%&'()*+,.-./:;<=>?@\\[\\\]^_‘{|}~]/
);

export const punctuationMarks = new RegExp(/[^\w\s\n\t]/);

export const wordsWithApostrofies = new RegExp(/(?=\S*['-])([a-zA-Z'-]+)/);
