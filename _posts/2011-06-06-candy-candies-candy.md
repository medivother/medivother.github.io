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



<script type="text/javascript" id="MathJax-script" async
  src="https://cdn.jsdelivr.net/npm/mathjax@3/es5/tex-mml-chtml.js">
</script>
<script>
  MathJax = {
    tex: {
      inlineMath: [['$', '$']]
    }
  };
</script>


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
In probability theory, a probability space or a probability triple $(Ω, F, P)$ is a mathematical construct that provides a formal model of a random process or “experiment”. For example, one can define a probability space which models the throwing of a die.

A probability space consists of three elements:

A sample space, $Ω$, which is the set of all possible outcomes.
An event space, which is a set of events F, an event being a set of outcomes in the sample space.
A probability function, which assigns each event in the event space a probability, which is a number between 0 and 1.
In order to provide a sensible model of probability, these elements must satisfy a number of axioms whjch we discussed in the previous article.

Concrete and simple examples of the probability measure space are related to gambling.

Let’s analyze the toss of a coin at first: if we do it once our sample space wille just be {H,T}, whereas if we toss it will be {HH,TT,HT,TH}; that’s more interesting, let’s take it into account for our example. Then the event space of this double toss would be the set of all the possible events that can occur, for example getting at least one head or two consecutive tails. Lastly there’s a probability function assigned to any of these events: for example the odds of tossing two heads in a row is 25%.

Another example of probability space could be shown from the extraction from a deck of cards. Let’s take a deck of 52 cards:

sample space = a list of all possible cards you could choose (H=hearts, D=diamonds, C=clubs, S=spades):
Ω = {AH,2H,3H,4H,5H,6H,7H,8H,9H,10H,JH,QH,KH, AD,2D,3D,4D,5D,6D,7D,8D,9D,10D,JD,QD,KD, AC,2C,3C,4C,5C,6C,7C,8C,9C,10C,JC,QC,KC, AS,2S,3S,4S,5S,6S,7S,8S,9S,10S,JS,QS,KS}.
event space = event of extracting a single card
probability function = for example the probability of choosing a two would be $\frac{1}{52} + \frac{1}{52} + \frac{1}{52} + \frac{1}{52} = \frac{4}{52} = \frac{1}{13} = 7,69%$.

## Measure Theory is the foundation of the Probability Theory
In mathematics measure theory is a theory that introduces the concept of measure. This concept is a generalization and formalization of geometrical measures like volume, area, length, but also of other kind of measures, like mass and, how we will see, probability.

The basic object of the measure theory is the measure space. A measure space is a triple $(X,A,μ)$ where:

- X is a set.
- A is a *σ-algebra* on the set X. A σ-algebra on a set X is a set of some possible subsets of X, closed under the operations of union, complement and intersection. Notice that in order to be a proper σ-algebra on X, A must always contain the empty set ∅ and the whole set X.
μ is a measure on the so called measurable space (X,A).
The measure μ associates a value to each possible $E∈A$ and is a proper measure if it has the following properties:

- *Non-negativity*: for all E in A, we have $μ(E)≥0$.
- *Null empty set*: $μ(∅)=0$
- *Countable additivity*: for all countable collections Ekk=1∞ of pairwise disjoint sets in A, then:


![509d1f0c8525754d4c35512fc706e9e645a50fdd](https://user-images.githubusercontent.com/99642347/205993250-25478259-15a4-4496-8d31-2b0f85e23f45.svg)

It’s easy to see that those three properties are the same that, according to the Kolmogorov axioms, belong to the probability (the Null empty set property for probability is easily implied by the three axioms). The only big difference is the Unitarity property, that probability has while measure has not.

We can then say that probability is a measure bound to 1: in other words, probability is a measure that assigns the value 1 to the entire measure space.

Since we defined probability as a measure, we can apply to probability all the results of the measure theory: in this sense, measure theory provides the mathematical foundation of the probability theory.

In fact, while in measure theory we define a measure space, in probability theory we define a probability space that is a triple (X,A,P) where:

- X is a set.
- A is a σ-algebra over X. An element E∈A is called event.
- P is a probability measure, that follows Kolmogorov axioms. As we said, the difference between a probability measure and the more general notion of measure is that a probability measure must assign value 1 to the entire probability space.

This definition manages to overcome all the problems that belonged to the other probability definitions (the classical definition, the frequentist interpretation, the subjective interpretation, ecc…) providing a strong mathematical base and allowing further developement of probability theory.

# Application

You can download the application from <a href="https://drive.google.com/file/d/1F46uWVuxOdnrzQWgFiZs-xpiZas0i5XG/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/206040896-5c3b4a1b-dc8d-4d61-a772-5f1b7b1420c1.mp4" controls="controls" style="max-width: 730px;">
</video>


## Description of the app
This application does two main things: it generates 100 sequences of n trials (chosen by the user) distributed according to a binomial with success probability p (aslo chosen by the user) and represents absolute,relative and normalized frequency; then it draws an histogram of the distribution of each frequency at the last trial. This was implemented using Bitmap and Graphics along with other elements and events which have already been used during this course such as buttons, scroll bars, pictureboxes and timers: this last element allowed me to make the application simulate "liveness". What I mean is that, as you can see in the video or running the app yourself, the sequences are generated one by one and also the histogram is adaptive to the new incoming points that update the distribution.

# Research on app
## Simple introduction to graphics in .NET
To create a simple graph in .NET we will need three simple tools:

1. Picturebox
2. Bitmap
3. Graphics

A PictureBox is, as its name says, a picture box needed to display an image in a window. A bitmap instead  defines a display space and the color for each pixel or “bit” in the display space: this means that creating this object, and associating it to a picturebox, we could change the single pixels of an image or draw something just by doing this, because it encapsulates every single pixel.

Finally, the bitmap we created must be encapsulated in a Graphics object. This object is needed to modify the image itself: applying methods on the Graphics object we will be able to perform various operations on the image and, doing so, draw our graphics.

The code below shows how to make such encapsulation of objects:

```
Bitmap b;
Graphics g;
b = new Bitmap(pictureBox1.Width,pictureBox1.Height);
g = Graphics.FromImage(b);
pictureBox1.Image = b;
```
## From real world coordinates to device cordinates

There are several differences between real world’s coordinates and the one represented in the digital world:

In the real world, a chart is displayed in a Cartesian plane, and each point of the chart is a couple of Real numbers. In the virtual world, the chart must be represented in an image composed by pixels: each point will be a pixel, and a pixel can be indexed in the bitmap with a couple of Integers.
In a Cartesian plane, if we consider just the first quadrant, the origin of the plane (0,0) will be placed down on the left. In the virtual world, a bitmap is a matrix of pixels: then, the coordinates (0,0) will refer to the pixel up on the left.
Having said that, two simple equations give us the solution to this problem, by translating real world coordinates to digital ones:

$X_v = X_r – X_{min} * W / X_{max} – X_{min}$

$Y_v = H – Y_r – Y_{min} * H / Y_{max} -Y_{min}$

Where $X_v$ and $Y_v$ are the digital coordinates we want to compute, while $X_r$ and $Y_r$ are the ones from the real world. W and H are respectively width and heigth in pixels of the window that will contain our graph, $X_{max}$ and ${X_min}$ (as ${Y_max}$ and ${Y_min}$) are the maximum and minimum values of X (Y) in the real world.
