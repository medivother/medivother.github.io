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

So if we want to obtain, for example, the joint relative frequency of event A and event B, we will need to do: $freq(A ∩ B) = freq(A)freq(B)$, which also means    $freq(A \mid B)=freq(A)$.

Conditional relative frequency then, is simply the relative frequency computed on a subset of the population.

Finally, we can show the mathematical relationship between the relative frequencies we computed in the previous article:

$freq(A \mid B) = freq(A)$
$freq(A ∩ B) = freq(A)freq(B)$ because: $freq(A ∩ B) = freq(A \mid B)freq(B) = freq(B \mid A)freq(A)$


# Application

You can download the application from <a href="https://drive.google.com/file/d/18GKUegWFUPcg5Vbk60R_OkEq9I17uvKR/view?usp=sharing" download>here</a>.

<video src="https://user-images.githubusercontent.com/99642347/205981253-9af5c967-7f83-4db0-9ae2-690ee5d15bf5.mp4" controls="controls" style="max-width: 730px;">
</video>


## Description of the app
That's definitely an upgrade from last homework. The csv parser is now capable of also displaying correctly all the elements of the file. Here we parse a file which had previously been obtained from sniffing the Wifi connection using Wireshark. On the right then is possible to see that the app computes both a univariate distribution and bivariate distribution.


# Research on app
## Online algorithms

In computer science, an online algorithm is one that can process an input which is a stream of data: it analyses this data piece-by-piece in a serial fashion, for example, in the order that the input is fed to the algorithm, without having the entire input available from the start.

Traditional algorithms for calculating statistics and models are often infeasible when working with big data. A statistician will run into problems of not just scalability, but of handling data arriving in a continuous stream. Online algorithms, which update estimates one observation at a time, can naturally handle big and streaming data.

We can show this difference between online and offline algorithms at first illustrating the calculation of an averge:


![online_algs](https://user-images.githubusercontent.com/99642347/205982280-492531c4-9f6e-4395-b471-3b39776cbc85.png)



The result of this two equasions is exactly the same, the difference relies on the execution inside a machine: the offline algorithm is computed having a list of values xi , which get summed together and divided by the total. This operation is dangerous because of the “two’s complement” which computers use to compute a sum, since in general, the range of an N-bit two’s complement number spans $[−2N−1, 2N−1 − 1]$, so for a huge set of data as a datastream $\sum x_i$ could be out of the span and alterate the result. On the other hand the online algorithm takes into account the previous value of the average $( θ_{n-1} )$, adding to the calculation the weighted difference between the new single value from the input stream and θn-1 . In fact the online equation is more clear if we see it like this:

$θ_n(online) = θ_{n-1} + \frac{(X_n – θ_{n-1}) }{n}$.

Doing it this way, we not only avoid the *two’s complement problem*, but we also need far less memory to store the average, because we only save $θ_{n-1}$ and $X_n$.

Other online algotithms, such as this one based on heaps, can calculate for example the median: the idea is to maintain smaller half and greater half in two heaps. The smaller half will be sorted in descending order, while greater half will be in ascending order. If I peek the smaller half, I’ll get the biggest value in the smaller half. If I peek the greater half, I’ll get the smallest value in the greater half. These values, two or one depending on the sizes, are the median.

