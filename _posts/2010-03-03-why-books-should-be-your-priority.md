---
date: 2018-11-22 12:26:40
layout: post
title: Homework 7
subtitle: Lorem ipsum dolor sit amet, consectetur adipisicing elit.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559822138/theme9_v273a9.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559822138/theme9_v273a9.jpg
category: life
tags:
  - books
  - read
author: mranderson
paginate: true
---

# Lebesgue-Stieltjes integration
In order to define the Lebesgue-Stieltjes integration, we first need to define the Lebesgue integration, of which the Lebesgue-Stieltjes is a generalization. To do that, we start from a generic definition of integral.

## Lebesgue integration
In mathematics, the integral of a non-negative function of a single variable can be regarded, in the simplest case, as the area between the graph of that function and the x-axis. This definition led to the mathematical formulation of the Riemann integrals, where a certain portion of the domain of a function is divided in to intervals, and we approximate the area under the function as the sum of the areas of the rectangles built on those intervals, whose heights are given by the graph of the function in those intervals. Reducing the length of the intervals into infinitesimals dx, we obtain the area under the function without approximation.

This definition suffices for simple functions, but not for more exotic functions. An example of a function that cannot be integrated under the Riemann definition is the Dirichlet function, defined as:1Q(x)={1x∈Q0x∉Q

This function is nowhere continuous and so cannot be integrated under the Riemann definition. Henri Lebesgue expanded the definition of integration in order to include also more complex functions: for example, the above Dirichlet function can be integrated with the Lebesgue integrals.

## Intuition behind Lebesgue integrals 1
Let’s now examine the difference between Riemann integrals and Lebesgue integrals from an intuitive point of view.

For the Riemann integral, the domain is partitioned into intervals, and bars are constructed to meet the height of the graph. The areas of these bars are added together, and this approximates the integral, in effect by summing areas of the form f(x)dx where f(x) is the height of a rectangle and dx is its width.

For the Lebesgue integral, the range is partitioned into intervals, and so the region under the graph is partitioned into horizontal “slabs” (which may not be connected sets). The area of a small horizontal “slab” under the graph of f, of height dy, is equal to the measure of the slab’s width times dy:μ({x∣f(x)>y})dy.

The Lebesgue integral may then be defined by adding up the areas of these horizontal slabs.

Formalization of Lebesgue integrals
In order to formalize the Lebesgue integration, we must identify some preliminary concepts: outer measure, Lebesgue measure, and Lebesgue-measurable functions.

## Outer measure 2
In the mathematical field of measure theory, an outer measure or exterior measure is a function defined on all subsets of a given set with values in the extended real numbers satisfying some additional technical conditions.

More formally, given a set X, let 2X denote the collection of all subsets of X, including the empty set ∅ . An outer measure on X is a set functionμ:2X→[0,∞]

such that:

null empty set: μ(∅)=0
monotone: if A and B are subsets of X with A⊆B, then μ(A)≤μ(B)
for arbitrary subsets B1,B2,… of X,
μ(⋃j=1∞Bj)≤∑j=1∞μ(Bj).

## Lebesgue measure 3
Now that we have defined what a generic outer measure is, we can define the Lebesgue measure, that is based upon the Lebesgue outer measure. The Lebesgue measure is the standard way of assigning a measure to subsets of n-dimensional Euclidean space. For n = 1, 2, or 3, it coincides with the standard measure of length, area, or volume.

Let’s now define the Lebesgue measure for subsets of the set R of real numbers.

For any interval I=[a,b], or I=(a,b), in the set R of real numbers, let ℓ(I)=b−a denote its length. For any subset E⊆R, the Lebesgue outer measure λ∗(E) is defined as an infimum:λ∗(E)=inf{∑k=1∞ℓ(Ik):(Ik)k∈N is a sequence of open intervals with E⊂⋃k=1∞Ik}

Some sets E satisfy the Carathéodory criterion, which requires that for every A⊆R,λ∗(A)=λ∗(A∩E)+λ∗(A∩Ec).

The set of all such E forms a σ-algebra. For any such E, its Lebesgue measure is defined to be its Lebesgue outer measure: λ(E)=λ∗(E).

A set E that does not satisfy the Carathéodory criterion is not Lebesgue-measurable. Non-measurable sets do exist; an example is the Vitali sets.

Then, the Lebesgue measure of a set E coincides with its Lebesgue outer measure when E respects the Carathéodory criterion, while it’s not defined if E does not respect it.

## Lebesgue-measurable functions 1
We start with a measure space (E,X,μ) where E is a set, X is a σ-algebra of subsets of E, and μ is a (non-negative) measure on E defined on the sets of X.

For example, E can be Euclidean n-space Rn or some Lebesgue measurable subset of it, X is the σ-algebra of all Lebesgue measurable subsets of E, and μ is the Lebesgue measure. In the mathematical theory of probability, we confine our study to a probability measure μ, which satisfies μ(E)=1.

Lebesgue’s theory defines integrals for a class of functions called measurable functions. A real-valued function f on E is measurable if the pre-image of every interval of the form (t,∞) is in X:{x∣f(x)>t}∈X∀t∈R

We can show that this is equivalent to requiring that the pre-image of any Borel subset of R be in X. Note that the Borel set on R is the smallest σ-algebra containing all the intervals of R. This means that if we compute the pre-image of any measurable set of the co-domain through f−1, we obtain a measurable set in the domain:∀b∈Bf−1(b)∈X

The set of measurable functions is closed under algebraic operations, but more importantly it is closed under various kinds of point-wise sequential limits:supk∈Nfk,lim infk∈Nfk,lim supk∈Nfk

are measurable if the original sequence (fk)k, where k∈N, consists of measurable functions.

## Lebesgue integral definition 1, 4
Now that we have formalized these concepts, we can proceed with the definition of the Lebesgue integration. The following that is reported is the definition via simple functions. A simple function is a finite linear combination of indicator functions of measurable sets.

An indicator function of a measurable set A is denoted as 1A:X→{0,1} and is defined as:1A(x)={1x∈A0x∉A

The Lebesgue integral of an indicator function will be:∫1Adμ=μ(A)

Where A is a Lebesgue-measurable set and μ is the Lebesgue measure.

A simple function is, as we said, a finite linear combination of indicator functions of measurable sets:s(x)=∑i=1nai1Ai(x)

Where 1Ai(x) is the indicator function for each Ai,i=1,…,n. For such a function, the Lebesgue integral on a set F∈X is defined as:∫Fsdμ=∑i=1naiμ(Ai∩F),F∈X

Finally we can define the Lebesgue integral for generic functions f. In particular, if f:E→R∗ is a non-negative function, the Lebesgue integral of f over a certain measurable set F is defined as:∫Ffdμ:=sup∫Fsdμ,

where the supremum is evaluated considering all the simple functions s such that 0≤s≤f. The value of the integral is a number in the interval [0,+∞].

Note that R∗ is the extended real set, defined as R∪(−∞;+∞).

The set of the functions such that:∫E|f|dμ<∞

is said set of the functions integrable over E according to Lebesgue with respect to the the measure μ (that, for what we said, is the Lebesgue measure), or also set of summable functions, and is denoted as L1(μ).

If f is not a non-negative function, in order to define the Lebesgue integral we have to pass through a little workaround. In fact, if f can include negative values, we can write it like f=f+−f−, where:f+(x)={f(x)if f(x)>00otherwisef−(x)={−f(x)if f(x)<00otherwise

Note that both f+ and f− are non-negative measurable functions. Also note that:|f|=f++f−.

We say that the Lebesgue integral of the measurable function f exists, or is defined, if at least one of ∫f+dμ and ∫f−dμ is finite:min(∫f+dμ,∫f−dμ)<∞

In this case we define:∫fdμ=∫f+dμ−∫f−dμ

Finally, we have that if∫|f|dμ<∞

we say that f is Lebesgue integrable.

## Lebesgue-Stieltjes integration 5
Now that we have defined the Lebesgue integration, we can define the Lebesgue-Stieltjes integration.

In defining the Lebesgue integration we saw that the measure used to compute the integral is the Lebesgue measure μ. The Lebesgue-Stieltjes integration is the Lebesgue integration that uses the Lebesgue-Stjeltes measure μg instead of the Lebesgue measure μ. We want now to define what the Lebesgue-Stjeltes measure is.

Given a function g:[a,b]→R that is monotone, non-decreasing and right-continuous, we can define w((s,t])=g(t)−g(s) and w(a)=0. Alternatively, if g is left continuous, we define w([s,t))=g(t)−g(s) and w(b)=0.

By Carathéodory’s extension theorem, there is a unique Borel measure μg on [a,b] which agrees with w on every interval I. The measure μg arises from an outer measure given by:μg(E)=inf{∑iμg(Ii) : E⊂⋃iIi}

This measure μg is the Lebesgue–Stieltjes measure associated with g. Notice how the definition is similar to the definition of the Lebesgue measure: it is in fact almost the same, but instead of ℓ(I)=b−a be the length of an interval I=(a,b), we will define this length as g(b)−g(a). If g is the identity function, the Lebesgue–Stieltjes measure corresponds with the Lebesgue measure.

Now that we defined the Lebesgue-Stieltjes measure, we can simply say that the Lebesgue–Stieltjes integral:∫abf(x)dg(x)

is defined as the Lebesgue integral of f with respect to the measure μg.









