---
date: 2018-07-20 12:26:40
layout: post
title: A wonderful serenity has taken possession of my entire soul
subtitle: Lorem ipsum dolor sit amet, consectetur adipisicing elit.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559820489/js-code_n83m7a.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559820489/js-code_n83m7a.jpg
category: code
tags:
  - platform
  - javascript
  - vscode
author: mranderson
---


# Arithmetic mean and its possible derivations
The word “statistics” is used in various ways: we used it to define a science, which we are studying at the moment; we usually use it when we look at graphs and charts, which we call “statistics”; lastly, this term can be used to define functions of the observed data.

The most famous and used of this family of functions is the mean, also known as average: to compute an average from a uniform set of data, we sum all of them and then we divide for the number of terms. But why do we do this? There are many possible ways to derive the mean, and we are going to analyze three of them, which are related to the properties of this function:

Invariance
Compensation
Minimization of the distance
Mean from the invariance property

The mean can be defined as the value that leaves F(d) unchanged. Let’s prove it:

tabella

Nx = ∑ xi = ∑xi/n

In this example our F(d) is a function that sums all of its terms, and then divides them by their number: the mean in this case is called “arithmetic mean”, and it represents a number which, if added into the set, basically leaves the sum unchanged. We can apply this reasoning also to different F(d): an example is the function which multiplies all the terms of the set. In this case the average is obtained by squaring this product of n terms by n, and the mean is called “geometric mean”. This function is deeply used in economics to, for example, get the average interest rate of a series.

Mean from compensation property

We could also derive the mean from the compensation property: compensation happens, for example, when the sum of positive and negative deviations between random points on a straight line and a certain fixed point is zero. This concept will be more clear looking at the graph below:

Grafico

From this, we can assume that:

∑(c-xi) L = ∑(xi -x) R

∑ cL – ∑ xi L= ∑ xi R – ∑ cR => ∑cL + ∑cR  = ∑ xi R + ∑ xi L => c = ∑ xi/n

Mean from the minimization of the distance

We could also define the mean as the value which is the nearest to the data.

Grafico

Given this graph, our aim is to find the value c so that it is the closest to all the point. We could either do it by making a difference  and using its absolute value

d(xi,c) = |xi -c|
or we could use the square

d(xi,c) ) (xi -c )2
Since we want a minimum, it is simpler to use this second method, but we need to choose the right unit of course.

∑min (xi -c)2

This is a specific case of a generic formula, which gives us all of the most used statistics:

∑min |xi -c|r

R=0 moda

R=1 median

R=2 arithmetic mean

ecc


# Mathematical convergence and convergence in probability
There is a difference between what we call mathematical convergence and the concept of convergence in probability: to show it, let’s define these two concepts before.

Mathematical convergence

Given Xn a sequence of real numbers, lim n->∞ xn = a if ∀ e>0 small there exist n0 s.t. |xn -a| < e ∀ n > n0

It would be great to do the same in probability, computing convergence just by making the limit of a sequence, but it is not the case: the definition of convergence in the probabilistic world is different because we have to deal with random variables, which behave in a complete different manner in contrast to a sequence Xn. So what we need to do first, is to define the concept of “distance of two random variables”.

Convergence in probability is based on the following intuition: two random variables are “close to each other” if there is a high probability that their difference is very small.

How to measure closeness

Let Xn be a sequence of random variables defined on a sample space Omega.

Take a random variable X and a strictly positive number epsilon.

Suppose that we consider X_n far from X when

|Xn -X | > e

Then, the probability

P(|Xn -X| > e) (1)

is the probability that X_n is far from X.

How to define convergence

If Xn converges to X, the probability that Xn and X are far from each other should become smaller and smaller as n increases.

In other words, we should have

Limn->∞ P(|Xn-X>e|) = 0

Note that P(|Xn-X>e|) is a sequence of real numbers. Therefore, the limit in equation (1) is the usual limit of a sequence of real numbers. We would like to be very restrictive on our criterion for deciding whether X_n is far from X. As a consequence, condition (1) should be satisfied for any, arbitrarily small, epsilon.

Definition for sequences of random variables

The intuitive considerations above lead us to the following definition of convergence.

Def Let Xn be a sequence of random variables defined on a sample space Omega. We say that Xn is convergent in probability to a random variable X defined on Omega if and only if

Lim n->∞ P(|Xn-X>e|) = 0 ∀ e>0

The variable X is called the probability limit of the sequence.



# Inferential vs Descriptive statistics
There are two main branches that coexist in the statistical world: descriptive and inferential statistics. They are used to describe the characteristics of a set of data. Descriptive statistics is a summary statistic that qualitatively describes a collection of information: in everyday life it can be seen in charts and graphs. Inferential statistics on the other hand is the process of using data analysis to deduce properties of a probability distribution, so it is used to quantitatively describe a dataset.



