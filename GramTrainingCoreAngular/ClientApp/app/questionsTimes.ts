import {Question} from './question.model';
import {Rule} from './rule.model';

export const questionsTimes: Question[] =
[
    new Question('Я співаю в обід', ['I sing in the afternoon',
    'I sings in the afternoon',
    'I am singing in the afternoon'], 0,
    new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true)),
    new Question('Він грає на гитарі по середам',
    ['He play guitar on Wednesday',
    'He plays guitar on Wednesday',
    'He played guitar on Wednesday',
    'He is playing guitar on Wednesday'], 1,
     new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true)),
     new Question('Мері живе у Парижі', ['Mary is living in Paris',
     'Mary lived in Paris', 'Mary live in Paris', 'Mary lives in Paris'], 3,
      new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true)),
      new Question('Тая і я любим грати у футбол', ['Taya and I likes playing football',
      'Taya and I did like playing football', 'Taya and I like playing football',
        'Taya and I is like playing football'], 2,
        new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true)),
      new Question('Твоя сестра любить море?', ['Does your sister like sea?',
      'Do your sister like sea?', 'Are your sister liking sea?',
      'Did your sister like sea?'], 0,
      new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true)),
      new Question('Тобі сподобалось на морі цим літом?', ['Does you like sea this summer?',
      'Did you like sea this summer?', 'Was you like sea this summer?',
        'Are you liking sea this summer?'], 1,
        new Rule(1, './assets/prezent-simpl-tablitsa.png', false, true)),
        new Question('Де живуть твої батьки?', ['Where your parents are living? ',
        'Where do your parents live?', 'Where did your parents live?',
        'Where does your parents live? '], 1,
        new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true)),
        new Question('Де живуть твої батьки?', ['Where your parents are living? ',
        'Where do your parents live?', 'Where did your parents live?',
        'Where does your parents live? '], 1,
        new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true))
  ];