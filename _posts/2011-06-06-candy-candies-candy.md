---
date: 2022-10-24 12:26:40
layout: post
title: Homework 4
subtitle: Axioms of probability and why measure theory is the foundation of probability.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559822137/theme11_vei7iw.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559822137/theme11_vei7iw.jpg
category: probability
tags:
  - food
  - tips
author: mranderson
---

# Relative frequency and axioms of probability
As we will discuss more precisely in the following articles of this homework, probability is an abstract entity, whit certain properties, which is based on axioms. Let’s analize them:

## 1st Axiom (Non-negativity)

- The probability of an event is a non-negative real number: $P(E) ∈ R, P(E) >= 0 ∀ E∈F$ where F is the space of the events. It follows that $P(E)$ is always finite, in contrast with more generale measure space theory

## 2nd Axiom (Unitarity)

- This is the assumption of unit measure: that the probability that at least one of the elementary events in the entire sample space will occur is 1 . $P(Ω) = 1$
## 3rd Axiom (Additivity)

- This is the assumption of sigma-additivity: any countable sequence of disjoint sets ( or mutually exclusive events ) E1,E2…. satisfies the fact that the probability of the union of the events is equal to the sum of their probabilities.
Since we analized relative frequencies in the previous articles, it is clear that there is a relationship between the above axioms and the formal properties of the relative frequency.

Since we have been working with populations and dataset, we can use the concept of “set” to talk about frequencies. Considering a population, which is a set of distinct entities, we can define subsets of them by grouping the ones with certain attributes: the relative frequency is then calculated dividing this subset by the total of the entities, which is the main set. Having said that, it is possible that there is no entity in our set which belongs a certain attribute, and in this case its frequency will be zero, but it is impossible for the frequency to be negative, as it is impossible for probability, thanks to the first axiom.

The same reasoning can be used to explain the relationship that occurs between the second axiom of probability, which states that the probability over the sample space is 1, and the fact that the relative frequency of all the events in the set is one. This means that the probability (frequency) that at least one of the elementary events in the entire sample space (dataset) will occur is 1.

Lastly, also additivity is both an axiom of the probability measure space and a formal property of the relative frequency. In fact, the frequency of the union of two or more subsets is the sum of those frequency, if they are distinguished. This means that the frequency of the union of all the events is equal to the sum of all the single frequencies, which is the same concept stated by the third axiom.



# Examples of probability measure space
In probability theory, a probability space or a probability triple (Ω, F, P) is a mathematical construct that provides a formal model of a random process or “experiment”. For example, one can define a probability space which models the throwing of a die.

A probability space consists of three elements:

A sample space, Ω, which is the set of all possible outcomes.
An event space, which is a set of events F, an event being a set of outcomes in the sample space.
A probability function, which assigns each event in the event space a probability, which is a number between 0 and 1.
In order to provide a sensible model of probability, these elements must satisfy a number of axioms whjch we discussed in the previous article.

Concrete and simple examples of the probability measure space are related to gambling.

Let’s analyze the toss of a coin at first: if we do it once our sample space wille just be {H,T}, whereas if we toss it will be {HH,TT,HT,TH}; that’s more interesting, let’s take it into account for our example. Then the event space of this double toss would be the set of all the possible events that can occur, for example getting at least one head or two consecutive tails. Lastly there’s a probability function assigned to any of these events: for example the odds of tossing two heads in a row is 25%.

Another example of probability space could be shown from the extraction from a deck of cards. Let’s take a deck of 52 cards:

sample space = a list of all possible cards you could choose (H=hearts, D=diamonds, C=clubs, S=spades):
Ω = {AH,2H,3H,4H,5H,6H,7H,8H,9H,10H,JH,QH,KH, AD,2D,3D,4D,5D,6D,7D,8D,9D,10D,JD,QD,KD, AC,2C,3C,4C,5C,6C,7C,8C,9C,10C,JC,QC,KC, AS,2S,3S,4S,5S,6S,7S,8S,9S,10S,JS,QS,KS}.
event space = event of extracting a single card
probability function = for example the probability of choosing a two would be 1/52 + 1/52 + 1/52 + 1/52 = 4/52 = 1/13 = 7,69%.

## Measure Theory is the foundation of the Probability Theory
In mathematics measure theory is a theory that introduces the concept of measure. This concept is a generalization and formalization of geometrical measures like volume, area, length, but also of other kind of measures, like mass and, how we will see, probability.

The basic object of the measure theory is the measure space. A measure space is a triple (X,A,μ) where:

X is a set.
A is a σ-algebra on the set X. A σ-algebra on a set X is a set of some possible subsets of X, closed under the operations of union, complement and intersection. Notice that in order to be a proper σ-algebra on X, A must always contain the empty set ∅ and the whole set X.
μ is a measure on the so called measurable space (X,A).
The measure μ associates a value to each possible E∈A and is a proper measure if it has the following properties:

Non-negativity: for all E in A, we have μ(E)≥0.
Null empty set: μ(∅)=0
Countable additivity: for all countable collections Ekk=1∞ of pairwise disjoint sets in A, then:
μ(⋃k=1∞Ek)=∑k=1∞μ(Ek)

It’s easy to see that those three properties are the same that, according to the Kolmogorov axioms, belong to the probability (the Null empty set property for probability is easily implied by the three axioms). The only big difference is the Unitarity property, that probability has while measure has not.

We can then say that probability is a measure bound to 1: in other words, probability is a measure that assigns the value 1 to the entire measure space.

Since we defined probability as a measure, we can apply to probability all the results of the measure theory: in this sense, measure theory provides the mathematical foundation of the probability theory.

In fact, while in measure theory we define a measure space, in probability theory we define a probability space that is a triple (X,A,P) where:

X is a set.
A is a σ-algebra over X. An element E∈A is called event.
P is a probability measure, that follows Kolmogorov axioms. As we said, the difference between a probability measure and the more general notion of measure is that a probability measure must assign value 1 to the entire probability space.
This definition manages to overcome all the problems that belonged to the other probability definitions (the classical definition, the frequentist interpretation, the subjective interpretation, ecc…) providing a strong mathematical base and allowing further developement of probability theory.

