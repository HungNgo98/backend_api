<?php

namespace Database\Factories;

use App\Models\Model;
use Faker\Provider\DateTime;
use Illuminate\Database\Eloquent\Factories\Factory;
use Faker\Generator as Faker;

class SupplierFactory extends Factory
{
    /**
     * The name of the factory's corresponding model.
     *
     * @var string
     */
    protected $model = Model::class;

    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'name'     => $this->faker->name,
            'password'     => '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi',
            'role'         => $this->faker->role,
            'status'     => $this->faker->status,
            'sex'=> $this->faker->randomElement(['nam','nu']),
            'created_at' => new DateTime,
            'updated_at' => new DateTime,
        ];
    }
}
