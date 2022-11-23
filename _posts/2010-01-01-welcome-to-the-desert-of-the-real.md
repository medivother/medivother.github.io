---
date: 2019-05-16T23:48:05.000Z
layout: post
title: Homework 8
subtitle: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit.'
description: >-
  Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
  tempor incididunt ut labore et dolore magna aliqua.
image: >-
  assets/img/prova8.png
optimized_image: >-
  assets/img/prova8.png
category: blog
tags:
  - welcome
  - blog
author: mranderson
paginate: true
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


# Possible derivation of the Normal Distribution
Abraham de Moivre, when he came up with this formula, had to assure that the points of inflection were exactly one standard deviation away from the center, and so that it was bell-shaped, as well as make sure that the area under the curve was exactly equal to one.And somehow they came up with the standard normal distribution, which is as follows:

$phi(x) = \frac{1}{\sqrt{2\pi}}e^{-\dfrac{1}{2}x^2}$
                                      
And even cooler, he found the distribution for when the mean was not 0 and the standard deviation was not 1, and came up with:

$f(x) = \frac{1}{\sigma\sqrt{2\pi}} e^{-\dfrac{(x - \mu)^2}{2\sigma^2}}$

This quote is from a a user on the web made me think a lot: it is frequent, for a student like me, to study concepts like the Normal Distribution, or the Lebsque integral or whatever formula, without completely making his mind about how the matematicians who studied it came up with that string of numbers. So let's get deep into the understanding of the possible derivation of the Normal Distribution.

## Idea explained by a user on StackExchange
Suppose I throw a dart into a dartboard. I aim at the centre of the board (0,0) but I'm not all that good with darts so the dart lands in a random position (X,Y) which has a joint density function f:R2→R+.

Let's make two assumptions about the way I play darts.

1. The density is rotationally invariant so the distribution of where my dart lands only depends on the distance of the dart to the centre.

2. The random variables X and Y are independent, how much I miss left and right makes no difference to the distribution of how much I miss up and down.

So by assumption one and Pythagoras I must be able to express the density
$f(x,y)=g(x2+y2)$.
Now as the random variables X and Y are independent and identically distributed I must be able to express
$f(x,y)∝f(x,0)f(0,y)$.
Combining these assumptions we get that for every pair $(x,y)$ we have
$g(x2+y2)∝g(x2)g(y2)$.
This means that g must be an exponential function
$g(t)=Ae^{−Bt}$.
So A will be some normalising constant. B somehow reflects the units I'm measuring in. (So if I measure the distance in cm B will be 10 times as big as if I measured in mm). B must be negative because the density should be a decreasing function of distance (I'm not that bad at darts.)

So to work out A I need to integrate $f(⋅,⋅)$ over R2 a quick change of coordinates and
$∬Rf(x,y)dxdy=2π∫∞0tg(t)dt=2πB2.$  	$\displaystyle \int_\int{R}^f(x,y)dxdy=2π\int_{0}^{\infty}tg(t)dt=2πB2.$
for

So we should set A=B22π it's convenient to choose B in terms of the standard deviation, so we set B=12σ and A=12πσ2.

So if I set f~(x)=12π√σe−x22σ then f(x,y)=f~(x)f~(y).

So the e comes from the fact I wanted my X and Y coordinates to be independent and the π comes from the fact that I wanted rotational invariance so I'm integrating over a circle.

The interesting thing happens if I throw two darts. Suppose I throw my first dart aiming at (0,0) which lands at (X1,Y1), I aim my next dart at the first dart, so this one lands at (X2,Y2) with X2=X1+X and Y2=Y1+Y.

So the position of the second dart is the sum of the two errors. But my sum is still rotationally invariant and the variables X2 and Y2 are still independent, so (X2,Y2) satisfies my two assumptions.

That means that when I add independent normal distributions together I get another normal distribution.

It's this property that makes it so useful, because if I take the average of a very long sequence of random variables I should get something that's the same shape no matter how long my sequence is and taking a sequence twice as long is like adding the two sequences together. It's this property of the normal distribution that makes it so useful.

The Normal distribution came about from approximations of the binomial distribution (de Moivre), from linear regression (Gauss), and from the central limit theorem. The derivation given by Tim relates more closely to the linear regression derivation, where the amount of error is represented by a Normal distribution when errors are assumed symmetric about a mean, and to decrease away from the mean
