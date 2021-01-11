<?php

namespace Database\Factories;

use App\Models\Product;
use Illuminate\Database\Eloquent\Factories\Factory;
use Illuminate\Support\Str;

class ProductFactory extends Factory
{
    /**
     * The name of the factory's corresponding model.
     *
     * @var string
     */
    protected $model = Product::class;

    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'name_product' => $this->faker->name_product,
            'img' => $this->faker->img,
            'price' => $this->faker->price,
            'content' => $this->faker->content,
            'remember_token' => Str::random(10),
        ];
    }
}
