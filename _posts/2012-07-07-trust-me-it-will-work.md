---
date: 2022-10-18 12:26:40
layout: post
title: Homework 3
subtitle: This article is about frequency in statistics. We will also analyze the concept of statistical independence.
description: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
image: https://res.cloudinary.com/dm7h7e8xj/image/upload/v1559821648/theme1_eoyjtl.jpg
optimized_image: https://res.cloudinary.com/dm7h7e8xj/image/upload/c_scale,w_380/v1559821648/theme1_eoyjtl.jpg
category: frequency
tags:
  - languages
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

# Conditional, joint and relative frequency
I will explain what conditional, joint and relative frequencies are using an example.

Let’s take a bivariate distribution taken from a survey on people attending an engeneering class: their attributes are their gender (boy or girl) and their favourite console to play videogames (PC, PlayStation or Xbox)


![hw3](https://user-images.githubusercontent.com/99642347/205971359-855af5ff-fad2-4916-97e4-be7d8999d4ce.png)
Bivariate distribution


In statistics, the frequency (or absolute frequency) of an event i is the number of times the observation ni occurred in an experiment or study: in our example, if we take into account as an event the fact that a student is a male or a famale, the absolute frequencies are boy=90 and girl=45. So to calculate an absolute frequency we consider only one attribute.

On the other hand, a relative frequency is the ratio of the frequency of a particular event in a statistical experiment to the total frequency.

There are three types of relative frequency:

- Joint Relative Frequency: The ratio that compares an intersection of qualitative data to the total frequency. In the table, the blue cells represent the joint relative frequency.
- Marginal Relative Frequency: The ratio that compares a qualitative total to the total frequency.  In the table above, the marginal frequencies can be found using the bottom or far-right “total” columns, the orange ones.
- Conditional Relative Frequency: A frequency that compares a specific joint relative frequency to a marginal relative frequency. So it is simply a relative frequency computed in a subset of the population.
Let’s go on with our example to explain these frequencies. An example of joint frequency is the number of girls that use the PlayStation: they are 30 over a total of 135 ( we can obtain this number by looking at the intersection of “Girl” and “Playstation”), so $J_{gp}= \frac{30}{135} = 0,22 = 22%$.

As we said in the definition , the marginal frequency is a ratio that compares a qualitative total (a specific attribute) to the total: in fact, a marginal distribution of a bivariate distribution is a univariate distribution. As an example of it we can take the number of PC players, which is 35, over 135: $\frac{35}{135} = 0,25 = 25%$. This means that 25% of our population plays videogames on the pc.

Lastly we can calculate the conditional frequency, which compares a joint frequency with a marginal one: doing this we are effectively imposing a condition. For example, let’s calculate the ratio of the boys how play the Xbox: the condition here is that we only care about a subset of our population, the boys, so we are going to take their marginal frequency which is 90.Give that we obtain $C_{b,x}=\frac{15}{90} = 0,16 = 16%.$

# Statistical independence
“Statistical independence is a concept in probability theory. Two events A and B are statistical independent if and only if their joint probability can be factorized into their marginal probabilities, i.e., $P(A \cup B) = P(A)P(B)$”

This definition of statistical independence gives us a hint about what this concept means, but we can go deeper: let’s start to undestand what independence means also in the frequency world, which is propedeutic to the probabilistic one.

If two attributes are independent, this means that the frequency of the first isn’t altered by the frequency of the second and vice versa. To give a more formal definition of it, we can say that independece between two attributes X and Y means that the conditional distribution of an attribute X over any value y∈Y has the same shape of the marginal distribution of X, and vice versa.

So if we want to obtain, for example, the joint relative frequency of event A and event B, we will need to do: $freq(A ∩ B) = freq(A) x freq(B)$, which also means $freq(A|B)=freq(A)$.

Conditional relative frequency then, is simply the relative frequency computed on a subset of the population.

Finally, we can show the mathematical relationship between the relative frequencies we computed in the previous article:

$freq(A|B) = freq(A)4
$freq(A ∩ B) = freq(A) x freq(B) because: freq(A ∩ B) = freq(A|B) x freq(B) = freq(B|A) x freq(A)$

